using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class FrequentCalls
    {
        public int Id { get; set; }
        public string Issi { get; set; }
        public string Name { get; set; }
        public int? PdtRule { get; set; }
        public string TerminalType { get; set; }
        public int? UserType { get; set; }
        public int? DispatchId { get; set; }
        public int? DataType { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
