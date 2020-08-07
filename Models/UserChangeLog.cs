using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class UserChangeLog
    {
        public int Id { get; set; }
        public string FromEntity { get; set; }
        public string SourceParentId { get; set; }
        public string ToEntity { get; set; }
        public int IsSelf { get; set; }
        public string ContentChanged { get; set; }
        public string AfterParentId { get; set; }
        public string OperateUser { get; set; }
        public DateTime Time { get; set; }
        public int? IsRecover { get; set; }
        public DateTime? Recovertime { get; set; }
    }
}
