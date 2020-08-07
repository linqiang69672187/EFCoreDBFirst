using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
