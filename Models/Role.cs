using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string Power { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string EnRoleName { get; set; }
    }
}
