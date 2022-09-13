using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Articleposition
    {
        public int Id { get; set; }
        public Guid ArticleGuid { get; set; }
        public string City { get; set; }
        public string RecommendPosition { get; set; }
    }
}
