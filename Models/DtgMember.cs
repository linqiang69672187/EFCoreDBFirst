using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class DtgMember
    {
        public int Id { get; set; }
        public int? DtgId { get; set; }
        public string MembIssi { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
