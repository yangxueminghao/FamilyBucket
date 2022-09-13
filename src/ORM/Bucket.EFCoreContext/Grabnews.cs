using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Grabnews
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string City { get; set; }
        public DateTime? AddTime { get; set; }
        public string SourceTime { get; set; }
        public int? Status { get; set; }
        public DateTime? HandleTime { get; set; }
        public string CategoryName { get; set; }
        public string Author { get; set; }
    }
}
