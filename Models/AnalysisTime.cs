using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class AnalysisTime
    {
        public int Id { get; set; }
        public int TimePlanId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string Remark { get; set; }
    }
}
