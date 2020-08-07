using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class GroupInfo
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string Gssi { get; set; }
        public string Gssis { get; set; }
        public string EntityId { get; set; }
        public bool? Status { get; set; }
        public byte IsExternal { get; set; }
        public string OriginalGssi { get; set; }
        public string TypeName { get; set; }
    }
}
