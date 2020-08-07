using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class PrePlanType
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
    }
}
