using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Sort { get; set; }
        public string Remark { get; set; }
    }
}
