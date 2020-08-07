using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Images
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageContentType { get; set; }
        public int? ImageSize { get; set; }
        public string Type { get; set; }
    }
}
