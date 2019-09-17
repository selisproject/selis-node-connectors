using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OrderWMSAdapter
{
    class Program
    {

        public static string scn_slug;
        static void Main(string[] args)
        {
            scn_slug = args[2];
            ImportOrderWMS(args[0],args[1]);

        }

        public static void ImportOrderWMS(string directory, string pubsuburl) {
            if (string.IsNullOrEmpty(directory) || string.IsNullOrEmpty(pubsuburl))
            {
                throw new Exception("Arguments cannot be null");
            }
            System.Collections.Generic.List<OrderWMS> orders = new System.Collections.Generic.List<OrderWMS>();
            bool skipheaders = true;
            string[] entries = null;
            string[] headers = null;

            System.Collections.Generic.List<char> delim = new System.Collections.Generic.List<char>();
            delim.Add('\r');
            delim.Add('\n');

            string[] files = System.IO.Directory.GetFiles(directory);

            foreach (var file in files) {
                if (!file.Contains("orderwms")) {
                    continue;
                }
                skipheaders = true;
                foreach (var row in System.IO.File.ReadAllText(file, System.Text.Encoding.GetEncoding(65001)).Split(delim.ToArray()) ?? Enumerable.Empty<string>())
                {
                    if (((((row == null || row == "")) == false) && (((row == null || row.Trim() == "")) == false)))
                    {
                        entries = row?.Split(';');
                        if ((skipheaders))
                        {
                            headers = row?.Split(';');
                            skipheaders = false;
                            continue;
                        }
                        if ((entries.Length > 0 && (entries[0] == null || entries[0] == "") == false))
                        {

                            OrderWMS order = new OrderWMS();

                            foreach (var property in typeof(OrderWMS).GetProperties()) {
                                int indexOfProperty = Array.IndexOf(headers, property.Name);
                                if (property.PropertyType == typeof(string))
                                {
                                    property.SetValue(order, entries[indexOfProperty]);
                                }
                                else if (property.PropertyType == typeof(int)) {
                                    property.SetValue(order, int.Parse(entries[indexOfProperty]));
                                }
                                else if (property.PropertyType == typeof(float))
                                {
                                    property.SetValue(order, float.Parse(entries[indexOfProperty]));
                                }
                                else if (property.PropertyType == typeof(DateTime))
                                {
                                    property.SetValue(order, DateTime.Parse(entries[indexOfProperty]));
                                }
                                else if (property.PropertyType == typeof(long))
                                {
                                    property.SetValue(order, long.Parse(entries[indexOfProperty]));
                                }
                            }
                            orders.Add(order);

                        }



                    }
                }
                string message = ConvertToPubSubMessage(orders);
                PostMessage(message, "");
                orders?.Clear();
            }
        }


        public static string ConvertToPubSubMessage<T>(List<T> converts) where T : class
        {
            string message = "{\"message_type\":\"" + typeof(T).Name + "\",\"scn_slug\":\""+scn_slug+"\",\"payload\":\"";
            string toreturn = string.Join(";", typeof(T).GetProperties().Select(x => x.Name));

            foreach (var convert in converts)
            {
                string toadd = string.Join(";", typeof(T).GetProperties().Select(x => x.GetValue(convert, null)?.ToString().Trim()));
                toreturn = toreturn + toadd + "\n";

            }
            return message + toreturn + "\"}";
        }

        public static string PostMessage(string message, string url)
        {
            string output;


            var clientHandler = new HttpClientHandler { ClientCertificateOptions = ClientCertificateOption.Manual };

            using (var client = new HttpClient(clientHandler))
            {
                var stringContent = new StringContent(message, Encoding.UTF8, "application/json");

                var postTask = client.PostAsync(url, stringContent);
                var response = postTask.Result;

                output = response.Content.ReadAsStringAsync().Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Server " + url
                                                        + " returned error. HTTP error code: " + response.StatusCode
                                                        + ", message: " + output);
                    return output;
                }
            }
            return output;
        }
    }

}
