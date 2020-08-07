using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class HistoryUserInStockade
    {
        public long Id { get; set; }
        public string StockadeId { get; set; }
        public int? UserId { get; set; }
        public int? EntityId { get; set; }
        public string StockStatus { get; set; }
        public DateTime? InsertTime { get; set; }
    }
}
