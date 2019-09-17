using NDesk.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailDataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = null;
            string slugName = null;
            string datasetType = null;
            string messageType = null;
            string delimiter = null;
            string pubsubURL = null;
            bool showHelp = false;

            var argParser = new OptionSet() {
                { "f|filepath=", "Full disk path of the csv dataset", f => { if (f != null ) filepath = f; } },
                { "s|slug_name=", "Full disk path of the csv dataset", s => { if(s != null) slugName = s; } },
                { "dt|dataset_type=", "CSV dataset type. Valid types: container, timetable, caldendar, wagonevent", d => { if(d != null) datasetType = d; } },
                { "m|message_type=", "Message type recognised by the Pub/Sub configuration", d => { if(d != null) datasetType = d; } },
                { "d|delimiter=", "CSV delimiter", d => { if(d != null) delimiter = d; else delimiter = ";"; } },
                { "u|url=", "PubSub URL address to post the parsed dataset", u => { if(u != null) pubsubURL = u; } },
                { "h|help=", "Display help message", h => { showHelp = h != null; } }
            };

            argParser.Parse(args);

            if (!showHelp && !string.IsNullOrEmpty(filepath) && !string.IsNullOrEmpty(slugName) && !string.IsNullOrEmpty(datasetType) && !string.IsNullOrEmpty(messageType) && !string.IsNullOrEmpty(pubsubURL))
            {
                switch (datasetType.ToLower())
                {
                    case "container":
                        var containerList = DatasetHandler.ImportFromCSV<Container>(filepath, delimiter);
                        var containerMessageToPost = DatasetHandler.ConvertToPubSubMessage(containerList, slugName, messageType);
                        DatasetHandler.PostMessage(containerMessageToPost, pubsubURL);
                        break;
                    case "timetable":
                        var timetableList = DatasetHandler.ImportFromCSV<TimeTable>(filepath, delimiter);
                        var timetableMessageToPost = DatasetHandler.ConvertToPubSubMessage(timetableList, slugName, messageType);
                        DatasetHandler.PostMessage(timetableMessageToPost, pubsubURL);
                        break;
                    case "caldendar":
                        var calendarList = DatasetHandler.ImportFromCSV<Caldendar>(filepath, delimiter);
                        var caldendarMessageToPost = DatasetHandler.ConvertToPubSubMessage(calendarList, slugName, messageType);
                        DatasetHandler.PostMessage(caldendarMessageToPost, pubsubURL);
                        break;
                    case "wagonevent":
                        var wagonEventList = DatasetHandler.ImportFromCSV<WagonEvent>(filepath, delimiter);
                        var wagonEventMessageToPost = DatasetHandler.ConvertToPubSubMessage(wagonEventList, slugName, messageType);
                        DatasetHandler.PostMessage(wagonEventMessageToPost, pubsubURL);
                        break;
                    default:
                        throw new Exception("Unsupported dataset type!");
                }

                Console.WriteLine($"Succesfully parsed {filepath} and posted to {pubsubURL}");
            }
            else
            {
                Console.WriteLine("Usage: adriakombiadapter [OPTION]...");
                Console.WriteLine("An interactive client for exporting assets");
                Console.WriteLine("Options:");
                argParser.WriteOptionDescriptions(Console.Out);
            }
        }

    }
}
