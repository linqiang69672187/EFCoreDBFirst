using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class OperationLog
    {
        public int Id { get; set; }
        public DateTime? SDate { get; set; }
        public string SchedulUnit { get; set; }
        public int? SchedulIssi { get; set; }
        public string SchedulIp { get; set; }
        public string SchedulLoginUser { get; set; }
        public string SchedulUserUnit { get; set; }
        public string SchedulUserName { get; set; }
        public string IdentityDeviceId { get; set; }
        public string IdentityDeviceName { get; set; }
        public string IdentityDeviceType { get; set; }
        public string IdentityDeviceUnit { get; set; }
        public string IdentityId { get; set; }
        public string IdentityName { get; set; }
        public string IdentityType { get; set; }
        public string IdentityUnit { get; set; }
        public string ModelName { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public int? Level { get; set; }
        public decimal? Lo { get; set; }
        public decimal? La { get; set; }
    }
}
