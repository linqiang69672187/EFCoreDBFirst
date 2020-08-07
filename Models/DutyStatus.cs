using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class DutyStatus
    {
        public int Id { get; set; }
        public int? DutyRecordId { get; set; }
        public string StepName { get; set; }
        public DateTime? ChangeTime { get; set; }
    }
}
