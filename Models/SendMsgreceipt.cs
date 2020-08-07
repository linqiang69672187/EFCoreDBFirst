using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class SendMsgreceipt
    {
        public long Id { get; set; }
        public string DestSsi { get; set; }
        public string SourceSsi { get; set; }
        public int? Reference { get; set; }
        public string Result { get; set; }
    }
}
