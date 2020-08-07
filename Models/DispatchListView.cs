using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class DispatchListView
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Issi { get; set; }
        public string EntityId { get; set; }
        public string Ipaddress { get; set; }
        public string LoginId { get; set; }
    }
}
