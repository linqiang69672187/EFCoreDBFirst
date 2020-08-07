using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class IssiInfo
    {
        public int Id { get; set; }
        public string Issi { get; set; }
        public string Gssis { get; set; }
        public string EntityId { get; set; }
        public byte? Status { get; set; }
        public string Bz { get; set; }
        public string IpAddress { get; set; }
        public string Typename { get; set; }
        public string OriginalIssi { get; set; }
        public string ProductModel { get; set; }
        public string Manufacturers { get; set; }
        public int? BsId { get; set; }
        public byte IsExternal { get; set; }
        public byte? IsUnderGround { get; set; }
        public int? IsOnline { get; set; }
        public int? OnlineSec { get; set; }
    }
}
