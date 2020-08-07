using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class UserDuty
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ProcedureId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Issi { get; set; }
        public string Name { get; set; }
        public string Num { get; set; }
        public int? EntityId { get; set; }
        public string Reserve1 { get; set; }
        public string Reserve2 { get; set; }
        public string Reserve3 { get; set; }
        public string Reserve4 { get; set; }
        public string Reserve5 { get; set; }
        public string Reserve6 { get; set; }
        public string Reserve7 { get; set; }
        public string Reserve8 { get; set; }
        public string Reserve9 { get; set; }
        public string Reserve10 { get; set; }
        public string Remark { get; set; }
    }
}
