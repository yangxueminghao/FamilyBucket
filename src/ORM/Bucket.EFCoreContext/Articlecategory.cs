using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Articlecategory
    {
        public int Id { get; set; }
        public Guid CategoryGuid { get; set; }
        public Guid? ParentGuid { get; set; }
        public string Name { get; set; }
        public sbyte IsSystem { get; set; }
        public int Status { get; set; }
        public string AdminComment { get; set; }
        public sbyte Deleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public sbyte IsVisible { get; set; }
        public string ImgUrl { get; set; }
        public int SortNumber { get; set; }
    }
}
