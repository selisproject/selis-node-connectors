using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailDataAdapter
{
    public class Caldendar
    {
        public int? CalendarId { get; set; }
        public int? TimetableId { get; set; }
        public DateTime? Announced { get; set; }
        public DateTime? Cancelled { get; set; }
        public bool? Private { get; set; }
        public DateTime? Departure { get; set; }
        public DateTime? Arrival { get; set; }
        public int? TimeTableId { get; set; }
        public string Weekdays { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTill { get; set; }
        public int? DepartureSecondOfTheDay { get; set; }
        public int? TrainId { get; set; }
        public int? TrainNumber { get; set; }
        public bool? HasReachedDestination { get; set; }
        public DateTime? ReachedDestinationDateTime { get; set; }
        public int? StartUIC { get; set; }
        public int? StartUicCountryId { get; set; }
        public int? EndUIC { get; set; }
        public int? EndUicCountryId { get; set; }
        public long? ExternalTrainId { get; set; }
        public string TrainCommercialName { get; set; }
        public int? LineId { get; set; }
    }
}
