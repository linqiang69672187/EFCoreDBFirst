using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class DispatchUserView
    {
        public int Id { get; set; }
        public string Issi { get; set; }
        public string Ipaddress { get; set; }
        public string Usename { get; set; }
        public DateTime? Loginintime { get; set; }
        public string LoginId { get; set; }
        public string EntityId { get; set; }
    }
}
