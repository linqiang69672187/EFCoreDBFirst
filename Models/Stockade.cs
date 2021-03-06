﻿using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Stockade
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string PointArray { get; set; }
        public string Title { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool? IsShow { get; set; }
        public string DivId { get; set; }
        public string DivStyle { get; set; }
        public int? Type { get; set; }
    }
}
