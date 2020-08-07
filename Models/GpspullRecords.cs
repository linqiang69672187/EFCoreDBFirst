using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class GpspullRecords
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? OperateTime { get; set; }
        public string SrcIssi { get; set; }
        public string OperateType { get; set; }
        public string Expire { get; set; }
        public string Period { get; set; }
        public string Distance { get; set; }
        public string DstIssi { get; set; }
        public string GisIssi { get; set; }
        public string GisAddr { get; set; }
        public string Result { get; set; }
        public string PullStatus { get; set; }
    }
}
