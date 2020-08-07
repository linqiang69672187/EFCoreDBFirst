using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class GisRecords
    {
        public int Id { get; set; }
        public string Issi { get; set; }
        public DateTime? Begtime { get; set; }
        public DateTime? Endtime { get; set; }
        public int? Cnt { get; set; }
        public string Username { get; set; }
        public string EntityId { get; set; }
    }
}
