using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class SmsInfo
    {
        public int Id { get; set; }
        public int Smstype { get; set; }
        public string SendIssi { get; set; }
        public string RevIssi { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsSend { get; set; }
        public string Smscontent { get; set; }
        public bool? IsReturn { get; set; }
        public DateTime? SendTime { get; set; }
        public DateTime? RevTime { get; set; }
        public DateTime? ReadTime { get; set; }
        public string Smsmsg { get; set; }
        public string Smsid { get; set; }
        public int? ReturnId { get; set; }
        public decimal? Lo { get; set; }
        public decimal? La { get; set; }
        public int? DispatcherId { get; set; }
        public int? IsGroup { get; set; }
    }
}
