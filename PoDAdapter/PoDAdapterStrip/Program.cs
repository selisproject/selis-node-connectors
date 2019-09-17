using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PoDAdapterStrip
{
    class Program
    {
        static void Main(string[] args)
        {
            ImportPods("", "");
        }

        public static void ImportPods(string directory, string pubsuburl)
        {
            if (string.IsNullOrEmpty(directory) || string.IsNullOrEmpty(pubsuburl))
            {
                throw new Exception("Arguments cannot be null");
            }
            System.Collections.Generic.List<ProofOfDelivery> pods = new System.Collections.Generic.List<ProofOfDelivery>();
            bool skipheaders = true;
            string[] entries = null;


            System.Collections.Generic.List<char> delim = new System.Collections.Generic.List<char>();
            delim.Add('\r');
            delim.Add('\n');

            string[] files = System.IO.Directory.GetFiles(directory);
            
            foreach (var file in files)
            {
                if (!file.Contains("OrdersExported")){
                    continue;
                }
                skipheaders = true;
                foreach (var row in System.IO.File.ReadAllText(file, System.Text.Encoding.GetEncoding(1253)).Split(delim.ToArray()) ?? Enumerable.Empty<string>())
                {
                    if (((((row == null || row == "")) == false) && (((row == null || row.Trim() == "")) == false)))
                    {
                        entries = row?.Split(';');
                        if ((skipheaders))
                        {
                            skipheaders = false;
                            continue;
                        }
                        if ((entries.Length > 0 && (entries[0] == null || entries[0] == "") == false))
                        {

             
                            ProofOfDelivery proof = new ProofOfDelivery();
                            try
                            {
                                proof.DateIssued = DateTime.Parse(entries[0]);
                            }
                            catch (System.Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            proof.PODNumber = entries[1].Trim();
                            proof.DeliveryStatus = entries[3];
                            pods?.Add(proof);


                        }



                    }
                }
                string message = ConvertToPubSubMessage(pods);
                PostMessage(message, "");
                pods?.Clear();
            }
        }


        public static string ConvertToPubSubMessage<T>(List<T> converts) where T : class
        {
            string message = "{\"message_type\":\"" + typeof(T).Name + "\",\"scn_slug\":\"elgeka\",\"payload\":\"";
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

