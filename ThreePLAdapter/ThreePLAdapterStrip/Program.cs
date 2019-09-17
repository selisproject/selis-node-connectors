using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ThreePLAdapterStrip
{
    class Program
    {
        static void Main(string[] args)
        {
            ImportAnswerToDep("", "");
        }

        public static void ImportAnswerToDep(string directory, string pubsuburl)
        {

            if (string.IsNullOrEmpty(directory) || string.IsNullOrEmpty(pubsuburl))
            {
                throw new Exception("Arguments cannot be null");
            }

            System.Collections.Generic.List<ThreePLAnswer> answers = new System.Collections.Generic.List<ThreePLAnswer>();
            bool skipheaders = true;
            string[] entries = null;


            System.Collections.Generic.List<char> delim = new System.Collections.Generic.List<char>();
            delim.Add('\r');
            delim.Add('\n');

            string[] files = System.IO.Directory.GetFiles(directory);

            foreach (var file in files)
            {
                if (!file.Contains("OUTB")) {
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

                            ThreePLAnswer answer;
                            answer = answers.FirstOrDefault(y => y.DeliveryNo == entries[11]);
                            if ((answer == null))
                            {
                                answer = new ThreePLAnswer();
                                answer.Products = new List<Product>();
                                answer.Document = file;
                                try
                                {
                                    answer.DeliveryDate = DateTime.ParseExact(entries[0], "yyyyMMd", System.Globalization.CultureInfo.InvariantCulture);
                                }
                                catch (System.Exception y)
                                {
                                    Console.WriteLine(y.Message);
                                }
                                answer.OrderNo = entries[12].Trim();
                                answer.ShippingDocument = new ShippingDocument();
                                answer.ShippingDocument.DocumentNo = entries[14];
                                answer.MaterialNumber = entries[4].Trim();
                                Product prod = new Product();
                                prod.Code = entries[4].Trim();
                                if (((((entries[7]) == null || entries[7] == "")) == false))
                                {
                                    if ((entries[7]).Contains("."))
                                    {
                                        string temp = entries[7].Split('.')[0];
                                        prod.Quantity = int.Parse(temp);
                                    }
                                    else
                                    {
                                        prod.Quantity = int.Parse(entries[7]);
                                    }
                                }
                                answer.Products.Add(prod);
                                answer.WareHouse = entries[5];
                                answer.CustomerCode = entries[9];
                                answer.DeliveryNo = entries[11];
                                answer.OrderNo = entries[12].Trim();
                                answer.PickingListNo = entries[13];
                                answer.VehiclePlateNo = entries[14];
                                answer.LineNo = entries[17];
                                answer.NoOfColli = entries[19];
                                answers?.Add(answer);
                            }
                            else
                            {
                                Product prod = new Product();
                                prod.Code = entries[4].Trim();
                                if (((((entries[7] == null || entries[7] == "")) == false)))
                                {
                                    if ((entries[7].Contains(".")))
                                    {
                                        string temp = entries[7].Split('.')[0];
                                        prod.Quantity = int.Parse(temp);
                                    }
                                    else
                                    {
                                        prod.Quantity = int.Parse(entries[7]);
                                    }
                                }
                                answer.Products.Add(prod);
                            }

                        }


             
                    }
                }
                string message= ConvertToPubSubMessage(answers);
                PostMessage(message, "");
                answers?.Clear();
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

