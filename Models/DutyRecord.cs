using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class DutyRecord
    {
        public int Id { get; set; }
        public int? UserDutyId { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string StepName { get; set; }
        public int? Cnt { get; set; }
        public string Remark { get; set; }
        public DateTime? StepChangeTime { get; set; }
    }
}
