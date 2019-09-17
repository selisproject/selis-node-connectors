using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailDataAdapter
{
    public class WagonEvent
    {
        public int? WagonEventId { get; set; }
        public int? WagonId { get; set; }
        public int? TrainId { get; set; }
        public string EventType { get; set; }
        public double? LocationX { get; set; }
        public double? LocationY { get; set; }
        public int? WagonStatusId { get; set; }
        public string WagonStatusName { get; set; }
        public int? WagonIrregularityId { get; set; }
        public string WagonIrregularityName { get; set; }
        public DateTime? EventDateTime { get; set; }
        public string Comment { get; set; }
        public int? RisStatusId { get; set; }
        public string RisStatusName { get; set; }
        public string LocationDescription { get; set; }
        public int? SourceId { get; set; }
        public string SourceName { get; set; }
        public bool? IsProcessed { get; set; }
        public int? DelaySeconds { get; set; }
        public int? TrainEventId { get; set; }
        public string Uic { get; set; }
        public int? StationId { get; set; }
        public int? TrainOperatingNumber { get; set; }
        public bool? IsDelayProcessed { get; set; }
        public string WagonEventStationCountryCode { get; set; }
        public string WagonEventStationName { get; set; }
    }
}
