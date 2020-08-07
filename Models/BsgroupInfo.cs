using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class BsgroupInfo
    {
        public int Id { get; set; }
        public string BsgroupName { get; set; }
        public string MemberIds { get; set; }
        public string EntityId { get; set; }
        public bool? Status { get; set; }
        public string Bsissi { get; set; }
    }
}
