using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class UserOnlines
    {
        public Guid Id { get; set; }
        public int? Useid { get; set; }
    }
}
