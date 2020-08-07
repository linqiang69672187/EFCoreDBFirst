using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class GpscontrolStatues
    {
        public int Id { get; set; }
        public string Issi { get; set; }
        public string Runner { get; set; }
        public DateTime? OperatorTime { get; set; }
        public string Gpsopen { get; set; }
        public int? OpenStatues { get; set; }
        public int? Gpscircle { get; set; }
        public int? CircleStatues { get; set; }
        public string Gpsdestination { get; set; }
        public int? DestinationStatues { get; set; }
        public int? GpsorBeidou { get; set; }
        public int? GpsorBeidoustatues { get; set; }
        public int? Gpsdistance { get; set; }
        public int? GpsdistanceStatues { get; set; }
    }
}
