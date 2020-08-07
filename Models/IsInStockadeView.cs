using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class IsInStockadeView
    {
        public string PointArray { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string UserId { get; set; }
        public string LoginName { get; set; }
        public string Nam { get; set; }
        public bool IsShow { get; set; }
        public string Issi { get; set; }
        public string DivStyle { get; set; }
        public string DivId { get; set; }
        public int? Type { get; set; }
        public string LastStatus { get; set; }
        public int UserInStockId { get; set; }
        public string Title { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
