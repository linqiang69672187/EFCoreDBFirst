using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class UsePramater
    {
        public int Id { get; set; }
        public string Lockid { get; set; }
        public string Username { get; set; }
        public int? DeviceTimeout { get; set; }
        public bool? HideTimeoutDevice { get; set; }
        public string RefreshMapInterval { get; set; }
        public string LastLo { get; set; }
        public string LastLa { get; set; }
        public bool? Displayinfo { get; set; }
        public string Concernids { get; set; }
        public string IsHideOfflineUserBySelect { get; set; }
        public string UserHeadInfo { get; set; }
        public string HeaderInfoStatusMode { get; set; }
        public byte? Voicetype { get; set; }
        public string IsOpenuserHeadInfo { get; set; }
    }
}
