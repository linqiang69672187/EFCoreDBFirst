using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class CallLog
    {
        public int Id { get; set; }
        public DateTime? SDate { get; set; }
        public string SchedulUnit { get; set; }
        public int? SchedulIssi { get; set; }
        public string SchedulIp { get; set; }
        public string SchedulUser { get; set; }
        public string SchedulUserUnit { get; set; }
        public string SchedulUserName { get; set; }
        public int? RevSsi { get; set; }
        public string RevUser { get; set; }
        public string RevType { get; set; }
        public string RevUnit { get; set; }
        public string RevDeviceUnit { get; set; }
        public string Apimsg { get; set; }
        public string Type { get; set; }
        public int? SendSsi { get; set; }
        public string SendUser { get; set; }
        public string SendType { get; set; }
        public string SendUnit { get; set; }
        public string SendDeviceUnit { get; set; }
        public string Remarks { get; set; }
    }
}
