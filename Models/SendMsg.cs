using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class SendMsg
    {
        public long Id { get; set; }
        public string DestSsi { get; set; }
        public string SourceSsi { get; set; }
        public int? Reference { get; set; }
        public string Consume { get; set; }
        public int? Length { get; set; }
        public string Content { get; set; }
    }
}
