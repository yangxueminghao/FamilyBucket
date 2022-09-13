using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Article
    {
        public int Id { get; set; }
        public Guid ArticalGuid { get; set; }
        public Guid CategoryGuid { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Author { get; set; }
        public string Abstract { get; set; }
        public string Keywords { get; set; }
        public string Content { get; set; }
        public string ConverImageUrl { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DatePublished { get; set; }
        public sbyte Deleted { get; set; }
        public string City { get; set; }
        public sbyte? IsHot { get; set; }
        public string RecommendPosition { get; set; }
        public Guid CreateUserId { get; set; }
        public Guid? ModifyUserId { get; set; }
        public sbyte IsUsedLandingPage { get; set; }
        public string Labels { get; set; }
        public string GrabId { get; set; }
        public sbyte? IsShow { get; set; }
    }
}
