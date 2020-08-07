using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class SwitchInfo
    {
        public int Id { get; set; }
        public int SwitchId { get; set; }
        public string SwitchName { get; set; }
        public string SwitchIp { get; set; }
        public bool? LocalMsc { get; set; }
    }
}
