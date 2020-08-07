using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class HistoryOnlineStatistics
    {
        public long Id { get; set; }
        public int? EntityId { get; set; }
        public long? OnlineTime { get; set; }
        public int? OnlineCnt { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
