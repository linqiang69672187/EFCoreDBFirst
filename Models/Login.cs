using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        public string Usename { get; set; }
        public string Pwd { get; set; }
        public string EntityId { get; set; }
        public string Hdissi { get; set; }
        public DateTime? Loginintime { get; set; }
        public DateTime? Lastinlinetime { get; set; }
        public int? Usertype { get; set; }
        public string AccessUnitsAndUsertype { get; set; }
        public int? RoleId { get; set; }
        public string Power { get; set; }
        public string DispatcherSelfPermissionEntites { get; set; }
        public string DispatcherPermissionEntites { get; set; }
        public int? EncType { get; set; }
    }
}
