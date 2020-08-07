using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class HistoryGisInfo
    {
        public string Issi { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public DateTime? SendTime { get; set; }
        public DateTime? InserttbTime { get; set; }
        public string HorizontalVelocity { get; set; }
        public string DirectionTravel { get; set; }
        public string SendReason { get; set; }
        public string PositionErr { get; set; }
        public string UserId { get; set; }
        public long Id { get; set; }
    }
}
