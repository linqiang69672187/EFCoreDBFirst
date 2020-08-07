using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class DxgroupInfo
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string GroupIndex { get; set; }
        public string Gssis { get; set; }
        public string EntityId { get; set; }
        public bool? Status { get; set; }
        public int? Gtype { get; set; }
    }
}
