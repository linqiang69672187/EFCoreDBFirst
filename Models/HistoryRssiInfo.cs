using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class HistoryRssiInfo
    {
        public long Id { get; set; }
        public string Issi { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public string MsRssi { get; set; }
        public string UlRssi { get; set; }
        public DateTime? InserttbTime { get; set; }
    }
}
