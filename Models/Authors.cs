using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Authors
    {
        public Authors()
        {
            Books = new HashSet<Books>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset BirthData { get; set; }
        public string BirthPlace { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
