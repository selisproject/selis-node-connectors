using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RailDataAdapter
{
    public class DatasetHandler
    {

        public static List<T> ImportFromCSV<T>(string filepath, string delimiter)
        {
            if (!File.Exists(filepath)) throw new FileNotFoundException($"File {filepath} could not be located!");

            var containerList = new List<T>();

            using (var reader = File.OpenText(filepath))
            {
                CsvReader csv = new CsvReader(reader);
                csv.Configuration.Delimiter = delimiter;
                csv.Configuration.TypeConverterCache.AddConverter(typeof(double), new HyphenToZeroConverter());
                csv.Configuration.MissingFieldFound = null;
                while (csv.Read())
                {
                    var record = csv.GetRecord<T>();
                    containerList.Add(record);
                }
            }

            return containerList;
        }

        public static string ConvertToPubSubMessage<T>(IEnumerable<T> converts, string scnSlug, string messageType) where T : class
        {
            var payload = string.Join(";", typeof(T).GetProperties().Select(x => x.Name));

            foreach (var convert in converts)
            {
                var value = string.Join(";", typeof(T).GetProperties().Select(x => x.GetValue(convert, null)?.ToString().Trim()));
                payload = payload + value + "\n";

            }

            return $@"{{""message_type"" : ""{messageType}"", ""scn_slug"" : ""{scnSlug}"", ""payload"" : ""{ payload }""}}";
        }

        public static string PostMessage(string message, string url)
        {
            var output = "";
            var clientHandler = new HttpClientHandler { ClientCertificateOptions = ClientCertificateOption.Manual };

            using (var client = new HttpClient(clientHandler))
            {
                var stringContent = new StringContent(message, Encoding.UTF8, "application/json");

                var postTask = client.PostAsync(url, stringContent);
                var response = postTask.Result;

                output = response.Content.ReadAsStringAsync().Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Server {url} returned error. HTTP error code: { response.StatusCode}, message: " + output);
                }
            }
            return output;
        }
    

    private class HyphenToZeroConverter : DoubleConverter
        {
            public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
            {
                var doubleCheck = new System.Text.RegularExpressions.Regex("[0-9]+\\.[0-9]+", System.Text.RegularExpressions.RegexOptions.Compiled);
                if (doubleCheck.IsMatch(text))
                {
                    text = text.Replace(".", ",");
                }

                return base.ConvertFromString(text, row, memberMapData);
            }
        }
    }
}
