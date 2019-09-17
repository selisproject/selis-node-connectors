using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailDataAdapter
{
    public class Container
    {
        public int? ContainerId { get; set; }
        public int? ContainerNumber { get; set; }
        public long? UtiId { get; set; }
        public string ContainerEndStationUIC { get; set; }
        public int? WagonId { get; set; }
        public int? WagonNumber { get; set; }
        public DateTime? WagonReachedDestinationDateTime { get; set; }
        public string WagonStartCountryCode { get; set; }
        public string WagonStartStationName { get; set; }
        public string WagonEndCountryCode { get; set; }
        public string WagonEndStationName { get; set; }
        public int? TrainId { get; set; }
        public int? CalendarId { get; set; }
        public int? TrainNumber { get; set; }
        public DateTime? TrainScheduledDepartureDateTime { get; set; }
        public DateTime? TrainReachedDestinationDateTime { get; set; }
        public long? ExternalTrainId { get; set; }
        public string TrainCommercialName { get; set; }
        public int? LineId { get; set; }
        public string TrainStartCountryCode { get; set; }
        public string TrainStartStationName { get; set; }
        public string TrainEndCountryCode { get; set; }
        public string TrainEndStationName { get; set; }
    }
}
