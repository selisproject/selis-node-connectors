using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailDataAdapter
{
    public class TimeTable
    {
        public int? TimeTableId { get; set; }
        public string Weekdays { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTill { get; set; }
        public int? LineId { get; set; }
        public string StationStartCountryCode { get; set; }
        public int? TrainNumber { get; set; }
        public string StationStartName { get; set; }
        public string StationEndCountryCode { get; set; }
        public string StationEndName { get; set; }
        public int? LineStationId { get; set; }
        public int? StationId { get; set; }
        public int? DayFromStart { get; set; }
        public int? StationOrder { get; set; }
        public int? ArrivalSecondOfTheDay { get; set; }
        public int? DepartureSecondOfTheDay { get; set; }
        public int? DistanceMeters { get; set; }
        public string CurrentStationCountryCode { get; set; }
        public string CurrentStationName { get; set; }
    }
}
