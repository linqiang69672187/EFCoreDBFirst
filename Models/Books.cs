using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Books
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
        public Guid AuthorId { get; set; }

        public virtual Authors Author { get; set; }
    }
}
