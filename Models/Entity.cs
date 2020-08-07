using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
        public string Depth { get; set; }
        public string Bz { get; set; }
        public decimal? Lo { get; set; }
        public decimal? La { get; set; }
        public string DivId { get; set; }
        public string PicUrl { get; set; }
        public string Color { get; set; }
        public int? ItselfFleet { get; set; }
    }
}
