using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class BeaconIdInfo
    {
        public int Id { get; set; }
        public string BeaconName { get; set; }
        public int? BeaconId { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public string Bz { get; set; }
        public decimal? FrequencyPoint { get; set; }
        public int? RssiThreshold { get; set; }
    }
}
