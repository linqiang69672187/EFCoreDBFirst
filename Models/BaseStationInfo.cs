using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class BaseStationInfo
    {
        public int Id { get; set; }
        public string StationName { get; set; }
        public string StationIssi { get; set; }
        public decimal? Lo { get; set; }
        public decimal? La { get; set; }
        public string DivId { get; set; }
        public string PicUrl { get; set; }
        public byte? IsUnderGround { get; set; }
        public int? SwitchId { get; set; }
    }
}
