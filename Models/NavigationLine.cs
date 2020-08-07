using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class NavigationLine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? EntityId { get; set; }
        public string Coordinates { get; set; }
        public int? Direction { get; set; }
    }
}
