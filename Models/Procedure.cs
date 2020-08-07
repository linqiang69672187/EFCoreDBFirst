using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Procedure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PType { get; set; }
        public int? LifeTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Remark { get; set; }
    }
}
