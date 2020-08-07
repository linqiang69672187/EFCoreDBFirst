using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class PoliceStrengthPlan
    {
        public int Id { get; set; }
        public int TrafficControlBoxId { get; set; }
        public int TimePlanId { get; set; }
        public int AnalysisTimeId { get; set; }
        public int PoliceStrengthPlanNum { get; set; }
        public string Remark { get; set; }
        public int InUse { get; set; }
    }
}
