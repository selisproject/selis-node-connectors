using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Net;

namespace DepositorAdapterStrip
{
    class Program
    {
        static void Main(string[] args)
        {
            ImportDepositorOrders("", "");
        }
       
        public static void ImportCustomers(string directory,string pubsuburl) {


            if (string.IsNullOrEmpty(directory) || string.IsNullOrEmpty(pubsuburl)) {
                throw new Exception("Arguments cannot be null");
            }
                bool skipheaders = true;
                string[] entries = null;
            
                System.Collections.Generic.List<Customer> customers = new System.Collections.Generic.List<Customer>();
                System.Collections.Generic.List<char> delim = new System.Collections.Generic.List<char>();
                delim.Add('\r');
                delim.Add('\n');

                string[] files = System.IO.Directory.GetFiles(directory);

                foreach (var file in files)
                {
                   
                    skipheaders = true;
                    foreach (var row in System.IO.File.ReadAllText(file,System.Text.Encoding.GetEncoding(1253)).Split(delim.ToArray()) ?? Enumerable.Empty<string>())
                    {
                        if (((((row == null || row == "")) == false) && (((row == null || row.Trim() == "")) == false)))
                        {
                            entries = row?.Split(';');
                            if ((skipheaders))
                            {
                                skipheaders = false;
                                continue;
                            }
                            if ((entries.Length > 0 && (entries[0] == null || entries[0] == "") == false) && ((entries[0].Contains("1")) == false) && ((entries[0].Contains("Κωδικός")) == false))
                            {
                                Customer customer = new Customer();
                                if (((entries[0] == null ||entries[0] == "")))
                                {
                                Console.WriteLine("Empty customer code in " + file);
                                    continue;
                                }
                                if (((entries[1] == null ||entries[1] == "")))
                                {
                                    Console.WriteLine("Empty Company Name but not customer code in " + file);
                                }
                                customer.CustomerCode =entries[0].Trim();
                                customer.CompanyName =entries[1];
                                customer.VATNo =entries[2];
                                customer.Occupation =entries[3];
                                customer.Telephone =entries[4];
                                customer.Region =entries[5];
                                customer.City =entries[6];
                                customer.Address =entries[7];
                                customer.PostalCode =entries[8];
                                customer.DOY =entries[9];
                                customer.Region_2 =entries[10];
                                customer.City_2 =entries[11];
                                customer.Address_2 =entries[12];
                                customer.PostalCode_2 =entries[11];
                                customers?.Add(customer);
                            }
                        }
                    }
                    string message = ConvertToPubSubMessage<Customer>(customers);
                Console.WriteLine(message);
                    var url = "";
                    Console.WriteLine(PostMessage(message, url));

                    customers?.Clear();
                }
            }

        public static void ImportProducts(string directory, string pubsuburl)
        {

            if (string.IsNullOrEmpty(directory) || string.IsNullOrEmpty(pubsuburl))
            {
                throw new Exception("Arguments cannot be null");
            }
            int rowCount = 0;
            bool skipheaders = true;
            string[] entries = null;

            System.Collections.Generic.List<Product> products = new System.Collections.Generic.List<Product>();
            System.Collections.Generic.List<char> delim = new System.Collections.Generic.List<char>();
            delim.Add('\r');
            delim.Add('\n');

            string[] files = System.IO.Directory.GetFiles(directory);

            foreach (var file in files)
            {

                skipheaders = true;
                foreach (var row in System.IO.File.ReadAllText(file,System.Text.Encoding.GetEncoding(1253)).Split(delim.ToArray()) ?? Enumerable.Empty<string>())
                {
                    if (((((row == null || row == "")) == false) && (((row == null || row.Trim() == "")) == false)))
                    {
                        entries = row?.Split(';');
                        if ((skipheaders))
                        {
                            skipheaders = false;
                            continue;
                        }
                        if ((entries.Length > 0 && ((entries[0] == null || entries[0] == "")) == false))
                        {
                            Product product = new Product();
                            product.Code = entries[0].Trim();
                            product.Description = entries[1];
                            product.BasicUnit = entries[2];
                            product.ConversionFactor = entries[3];
                            product.SaleUnit = entries[4];
                            if ((((entries[5] == null || entries[5] == "")) == false))
                            {
                                try
                                {
                                    product.GrossWeight = Decimal.Parse(entries[5].Trim().Replace(",", "."), System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
                                }
                                catch (System.Exception x)
                                {
                                    if ((entries[5] == null || entries[5] == ""))
                                    {
                                        Console.WriteLine("Entry 19 is Null or Empty");
                                    }
                                    else
                                    {
                                        Console.WriteLine("RowCount:" + rowCount + "GrossWeight:" + entries[5] + " had Exception:" + x.Message);
                                    }
                                }
                            }
                            if ((((entries[6] == null || entries[6] == "")) == false))
                            {
                                try
                                {
                                    product.Volume = Decimal.Parse(entries[6].Trim().Replace(",", "."), System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
                                }
                                catch (System.Exception x)
                                {
                                    if ((entries[6] == null || entries[6] == ""))
                                    {
                                        Console.WriteLine("Entry 6 is Null or Empty");
                                    }
                                    else
                                    {
                                        Console.WriteLine("product.Volume:" + entries[6] + " had Exception:" + x.Message);
                                    }
                                }
                            }
                            product.EAN_Tem = entries[8];
                            product.EAN_Kib = entries[9];
                            product.Type = entries[10];
                            product.LifeDuration = entries[12];
                            product.Warning = entries[13];
                           // product.StopSelling = int.Parse(entries[14]);
                            products.Add(product);
                        }
                    }
                    rowCount = rowCount + 1;
                }
                string message = ConvertToPubSubMessage<Product>(products);
                var url = "";
                Console.WriteLine(PostMessage(message, url));
                products.Clear();
            }
        }

        public static void ImportDepositorOrders(string directory, string pubsuburl)
        {
            if (string.IsNullOrEmpty(directory) || string.IsNullOrEmpty(pubsuburl))
            {
                throw new Exception("Arguments cannot be null");
            }
            bool skipheaders = true;
            string[] entries = null;
            int rowCount = 0;
            bool fileerror;

            System.Collections.Generic.List<DepositorOrder> orders = new System.Collections.Generic.List<DepositorOrder>();
            System.Collections.Generic.List<char> delim = new System.Collections.Generic.List<char>();
            delim.Add('\r');
            delim.Add('\n');

            string[] files = System.IO.Directory.GetFiles(directory);

            foreach (var file in files)
            {
                if (!file.Contains("DLVRY")) {
                    continue;
                }
                skipheaders = true;
                foreach (var row in System.IO.File.ReadAllText(file,System.Text.Encoding.GetEncoding(1253)).Split(delim.ToArray()) ?? Enumerable.Empty<string>())
                {
                    if (((((row == null || row == "")) == false) && (((row == null || row.Trim() == "")) == false)))
                    {
                        entries = row?.Split(';');
                        if ((skipheaders))
                        {
                            skipheaders = false;
                            continue;
                        }
                        if ((entries.Length > 0 && ((entries[0].Contains("Order")) == false) && ((entries[0].Contains("erdat")) == false)))
                        {
                            DepositorOrder order = orders?.FirstOrDefault((x) => x.DeliveryNo == entries[1]);
                            if (((entries[0] == null || entries[0] == "") || entries[0].Length != 8))
                            {
                                Console.WriteLine("Null creation date on " + file);
                                continue;
                            }
                            if ((entries[0] == "00000000"))
                            {
                                Console.WriteLine("bad data on file" + file);
                                continue;
                            }
                            if ((order == null))
                            {
                                order = new DepositorOrder();
                                order.products = new List<Product>();
                                try
                                {
                                    order.CreationDate = DateTime.ParseExact(entries[0], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                                }
                                catch (System.Exception x)
                                {
                                    Console.WriteLine(file + ": Error parsing CreationDate value: " + entries[0]);
                                    fileerror = true;
                                    continue;
                                }
                                order.DeliveryNo = entries[1];
                                try
                                {
                                    order.DeliveryDateFrom = DateTime.ParseExact(entries[2], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                                }
                                catch (System.Exception x)
                                {
                                    Console.WriteLine(file + ": Error parsing DeliveryDateFrom value: " + entries[2]);
                                    continue;
                                    fileerror = true;
                                }
                                try
                                {
                                    order.DeliveryDateTo = DateTime.ParseExact(entries[3], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                                }
                                catch (System.Exception x)
                                {
                                    Console.WriteLine(file + ": Error parsing DeliveryDateTo value: " + entries[3]);
                                    fileerror = true;
                                    continue;
                                }
                                order.WareHouse = entries[6];
                                Product product = new Product();
                                product.Code = entries[7].Trim();
                                try
                                {
                                    product.Quantity = int.Parse(entries[9]);
                                }
                                catch (System.Exception x)
                                {
                                    if (((entries[9] == null || entries[9] == "")))
                                    {
                                        Console.WriteLine(file + ": ProductQuantity is Null or Empty");
                                    }
                                    else
                                    {
                                        Console.WriteLine(file+ ": product.Quantity:" + entries[9] + " failed to int parse");
                                    }
                                }
                                order.products.Add(product);
                                order.customer = new Customer();
                                order.customer.CustomerCode = entries[10];
                                order.Comments = entries[19];
                                order.Document = file;
                                if (((((entries[23] == null || entries[23] == "")) == false)))
                                {
                                    order.PayerCode = entries[23];
                                }
                                orders?.Add(order);
                            }
                            else
                            {
                                Product product = new Product();
                                product.Code = entries[7].Trim();
                                product.Quantity = int.Parse(entries[9]);
                                order.products.Add(product);
                            }
                        }
                    }
                    if (orders.Count != 0)
                    {
                        string message = ConvertToPubSubMessage(orders);
                        PostMessage(message, "");
                        orders.Clear();
                    }
                }
            }
        }

        public static void ImportInvoices(string directory, string pubsuburl) {
            if (string.IsNullOrEmpty(directory) || string.IsNullOrEmpty(pubsuburl))
            {
                throw new Exception("Arguments cannot be null");
            }
            bool skipheaders = true;
            string[] entries = null;
            int rowCount = 0;
            bool fileerror = false;

            System.Collections.Generic.List<Invoice> invoices = new System.Collections.Generic.List<Invoice>();
            System.Collections.Generic.List<char> delim = new System.Collections.Generic.List<char>();
            delim.Add('\r');
            delim.Add('\n');

            string[] files = System.IO.Directory.GetFiles(directory).Where(x=>x.Contains("INV")).ToArray();

            foreach (var file in files)
            {

                skipheaders = true;
                foreach (var row in System.IO.File.ReadAllText(file,System.Text.Encoding.GetEncoding(1253)).Split(delim.ToArray()) ?? Enumerable.Empty<string>())
                {
                    if (((((row == null || row == "")) == false) && (((row == null || row.Trim() == "")) == false)))
                    {
                        entries = row?.Split(';');
                        if ((skipheaders))
                        {
                            skipheaders = false;
                            continue;
                        }


                        if ((entries[8].Length != 8 || entries[4].Length != 8))
                        {
                            Console.WriteLine(file);
                        }
                        Invoice invoice = invoices?.FirstOrDefault((y) => y.DeliveryNo == entries[5]);
                        if ((invoice == null))
                        {
                            invoice = new Invoice();
                            invoice.Products = new List<Product>();
                            Product prod = new Product();
                            invoice.DeliveryNo = entries[5];
                            invoice.DeliveryLegalDoc = entries[7];
                            invoice.BillingLegalDoc = entries[11];
                            if ((invoice?.DeliveryLegalDoc?.Contains("ΤΔΑ") ?? false))
                            {
                                invoice.isTDA = true;
                            }
                            else
                            {
                                invoice.isTDA = false;
                            }
                            invoice.BillingNo = entries[9];
                            try
                            {
                                invoice.BillingDate = DateTime.ParseExact(entries[8], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                            }
                            catch (System.Exception x)
                            {
                                if ((((fileerror) == false)))
                                {
                                    Console.WriteLine("Error in file" + file);
                                    fileerror = true;
                                }
                            }
                            try
                            {
                                invoice.DeliveryDate = DateTime.ParseExact(entries[4], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                            }
                            catch (System.Exception x)
                            {
                                if ((((fileerror) == false)))
                                {
                                    Console.WriteLine("Error in file" + file);
                                    fileerror = true;
                                }
                            }
                            invoice.BillingLine_No = entries[10];
                            prod.Code = entries[15].Trim();
                            prod.SaleUnit = entries[20];
                            try
                            {
                                prod.BillingQuantity = Decimal.Parse(entries[19].Trim(), System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
                            }
                            catch (System.Exception x)
                            {
                                Console.WriteLine(x.Message + "on file" + file);
                            }

                            if (((((entries[18] == null || entries[18] == "")) == false)))
                            {
                                try
                                {
                                    prod.OrderQuantity = long.Parse(entries[18].Trim());
                                }
                                catch (System.Exception x)
                                {
                                    Console.WriteLine(entries[18] + "issue on " + file);
                                }
                            }
                            if ((entries[21] == null || entries[21] == ""))
                            {
                                prod.GrossValue = 0;
                            }
                            else
                            {
                                try
                                {
                                    prod.GrossValue = Decimal.Parse(entries[21].Trim().Replace(",", "."), System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
                                }
                                catch (System.Exception x)
                                {
                                    Console.WriteLine(entries[21] + " error parsing on " + file);
                                    prod.GrossValue = 0;
                                }
                            }
                            if (((((entries[22] == null || entries[22] == "")) == false) || ((entries[22].Contains("***")) == false)))
                            {
                                try
                                {
                                    prod.NetValue = Decimal.Parse(entries[24].Trim().Replace(",", "."), System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
                                }
                                catch (System.Exception x)
                                {
                                    Console.WriteLine(entries[22] + " error parsing on " + file);
                                }
                            }
                            else
                            {
                                prod.NetValue = 0;
                            }
                            if (((entries[23]) == null || entries[23] == "") || entries[23].Contains("***"))
                            {
                                prod.VatValue = 0;
                            }
                            else
                            {
                                try
                                {
                                    string vatval = entries[23].Trim().Replace(",", ".");
                                    prod.VatValue = Decimal.Parse(vatval, System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
                                }
                                catch (System.Exception x)
                                {
                                    Console.WriteLine(entries[23] + " error parsing on " + file);
                                }
                            }
                            if (((entries[24] == null || entries[24] == "") || entries[24].Contains("***")))
                            {
                                prod.TotalValue = 0;
                            }
                            else
                            {
                                try
                                {
                                    string totalva = entries[24].Trim().Replace(",", ".");
                                    prod.TotalValue = Decimal.Parse(totalva, System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
                                }
                                catch (System.Exception x)
                                {
                                    Console.WriteLine(entries[24] + " error parsing on " + file);
                                }
                            }
                            invoice.OrderNo = entries[13].Trim();
                            invoice.DeliveryLine_No = entries[6].Trim();
                            int orderlineno;
                            if (int.TryParse(entries[14].Trim(), out orderlineno)) {
                                invoice.OrderLine = orderlineno;
                            };

                            invoice.Products.Add(prod);
                            invoice.Customer = new Customer();
                            invoice.Customer.CustomerCode = entries[1];
                            invoice.Document = file;
                            invoice.Products.Add(prod);
                            invoices.Add(invoice);
                        }
                        else
                        {
                            Product prod = new Product();
                            prod.Code = entries[15].Trim();
                            prod.SaleUnit = entries[20];
                            try
                            {
                                prod.BillingQuantity = Decimal.Parse(entries[19].Trim().Replace(",", "."), System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
                            }
                            catch (System.Exception x)
                            {
                                if (((entries[19] == null || entries[19] == "")))
                                {
                                    Console.WriteLine("19 is Null or Empty");
                                }
                                else
                                {
                                    Console.WriteLine("prod.BillingQuantity:" + entries[19] + " had Exception:" + x.Message);
                                }
                            }
                            if (((((entries[18] == null || entries[18] == "")) == false)))
                            {
                                try
                                {
                                    prod.OrderQuantity = long.Parse(entries[18].Trim().Replace(",", "."));
                                }
                                catch (System.Exception x)
                                {
                                    Console.WriteLine(entries[18] + " 18 on" + file);
                                }
                            }
                            else
                            {
                                prod.OrderQuantity = 0;
                            }
                            if (((entries[21] == null || entries[21] == "")))
                            {
                                prod.GrossValue = 0;
                            }
                            else
                            {
                                try
                                {
                                    string something = entries[21].Trim().Replace(",", ".");
                                    prod.GrossValue = Decimal.Parse(something, System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
                                }
                                catch (System.Exception x)
                                {
                                    Console.WriteLine(x.Message);
                                    Console.WriteLine(entries[21] + "21");
                                }
                            }
                            if (((((entries[22] == null || entries[22] == "")) == false) || ((entries[22].Contains("***")) == false)))
                            {
                                try
                                {
                                    string netval = entries[22].Trim().Replace(",", ".");
                                    prod.NetValue = Decimal.Parse(netval, System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
                                }
                                catch (System.Exception x)
                                {

                                    prod.NetValue = 0;
                                    Console.WriteLine(entries[22] + " error parsing 22");
                                }
                            }
                            else
                            {
                                prod.NetValue = 0;
                            }
                            if (((entries[23] == null || entries[23] == "") || ((entries[23].Contains("***")) == false)))
                            {
                                prod.VatValue = 0;
                            }
                            else
                            {
                                try
                                {
                                    string vatval = entries[23].Trim().Replace(",", ".");
                                    prod.VatValue = Decimal.Parse(vatval, System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
                                }
                                catch (System.Exception x)
                                {
                                    prod.VatValue = 0;
                                    Console.WriteLine(entries[23] + " error parsing on " + file);
                                }
                            }
                            if (((entries[24] == null || entries[24] == "") || ((entries[24].Contains("***")) == false)))
                            {
                                prod.TotalValue = 0;
                            }
                            else
                            {
                                try
                                {
                                    string totalva = entries[24].Trim().Replace(",", ".");
                                    prod.TotalValue = Decimal.Parse(totalva, System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture);
                                }
                                catch (System.Exception x)
                                {

                                    prod.TotalValue = 0;
                                    Console.WriteLine(entries[24] + " error parsing");
                                }
                            }
                            invoice.Document = file;
                            invoice.Products.Add(prod);
                            rowCount = rowCount + 1;
                        }

                    }


                    
                }
                foreach (var inv in invoices)
                {
                    decimal total = 0;
                    decimal vat = 0;
                    decimal gross = 0;
                    decimal net = 0;
                    foreach (var prod in inv.Products)
                    {
                        vat = vat + (prod.VatValue);
                        total = total + (prod.TotalValue);
                        gross = gross + (prod.GrossValue);
                        net = net + (prod.NetValue);
                    }
                    inv.NetValue = net;
                    inv.GrossValue = gross;
                    inv.TotalVAT = vat;
                    inv.TotalValue = total;
                }
                string message = ConvertToPubSubMessage<Invoice>(invoices);
                Console.WriteLine(message);
                PostMessage(message, "");
                invoices.Clear();
            } }

        public static string ConvertToPubSubMessage<T>(List<T> converts) where T : class
        {
            string message = "{\"message_type\":\""+typeof(T).Name+"\",\"scn_slug\":\"elgeka\",\"payload\":\"";
            string toreturn = string.Join(";", typeof(T).GetProperties().Select(x => x.Name));

            foreach (var convert in converts)
            {
                string toadd = string.Join(";", typeof(T).GetProperties().Select(x => x.GetValue(convert, null)?.ToString().Trim()));
                toreturn = toreturn + toadd + "\n";

            }
            return message + toreturn + "\"}";
        }

        
        
        public static string PostMessage(string message, string url) {
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

