using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class TrafficControlBox
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BoxType { get; set; }
        public string Coordinates { get; set; }
        public double? Radius { get; set; }
        public string Remark { get; set; }
        public int EntityId { get; set; }
    }
}
