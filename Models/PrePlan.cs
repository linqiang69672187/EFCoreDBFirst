using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class PrePlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PlanType { get; set; }
        public byte[] Url { get; set; }
        public string CreateDate { get; set; }
        public string FileName { get; set; }
    }
}
