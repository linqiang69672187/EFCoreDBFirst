using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class UserInStockade
    {
        public int Id { get; set; }
        public string StockadeId { get; set; }
        public int? UserId { get; set; }
        public string LastStatus { get; set; }
        public decimal? Distance { get; set; }
        public decimal? Lo { get; set; }
        public decimal? La { get; set; }
        public DateTime? InsertTime { get; set; }
    }
}
