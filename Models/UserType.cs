using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class UserType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string TypeIcons { get; set; }
        public string NormalIcons { get; set; }
        public string UrgencyIcons { get; set; }
        public string UnNormalIcons { get; set; }
        public string CanvasIcons { get; set; }
    }
}
