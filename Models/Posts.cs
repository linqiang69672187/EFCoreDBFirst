using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Posts
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Title2 { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }

        public virtual Blogs Blog { get; set; }
    }
}
