using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class UserInfo
    {
        public int Id { get; set; }
        public string Nam { get; set; }
        public string Num { get; set; }
        public string Issi { get; set; }
        public string EntityId { get; set; }
        public string Type { get; set; }
        public string Bz { get; set; }
        public bool? IsDisplay { get; set; }
        public int? TypeId { get; set; }
        public string UserIcons { get; set; }
        public string Position { get; set; }
        public string Telephone { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public int? ShipType { get; set; }
        public int? BsId { get; set; }
    }
}
