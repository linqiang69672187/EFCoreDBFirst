using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class PowerFunction
    {
        public int Id { get; set; }
        public string PowerKey { get; set; }
        public string PowerName { get; set; }
        public string EnPowerName { get; set; }
        public string Remark { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
