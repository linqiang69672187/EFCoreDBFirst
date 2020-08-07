using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class UserIssiView
    {
        public int Id { get; set; }
        public string Nam { get; set; }
        public string UserIssi { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public int? UserId { get; set; }
    }
}
