using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Step
    {
        public int Id { get; set; }
        public int? ProcedureId { get; set; }
        public string Command { get; set; }
        public string Name { get; set; }
        public byte? MarkId { get; set; }
        public string Remark { get; set; }
    }
}
