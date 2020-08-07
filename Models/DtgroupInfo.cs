using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class DtgroupInfo
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string Value { get; set; }
        public string EntityId { get; set; }
        public bool? Status { get; set; }
        public string Gssi { get; set; }
    }
}
