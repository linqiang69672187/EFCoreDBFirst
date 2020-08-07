using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class VideoInfo
    {
        public int Id { get; set; }
        public string VideoName { get; set; }
        public string VideoPlayUrl { get; set; }
        public decimal? Lo { get; set; }
        public decimal? La { get; set; }
        public string DivId { get; set; }
        public string PicUrl { get; set; }
    }
}
