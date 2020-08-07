using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class EntityDevice
    {
        public int Id { get; set; }
        public int? EntityId { get; set; }
        public string EntityName { get; set; }
        public int? Online { get; set; }
        public int? Total { get; set; }
    }
}
