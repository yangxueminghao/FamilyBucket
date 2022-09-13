using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Adsense
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
        public string Url { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? CreaterId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public Guid? UpdaterId { get; set; }
        public sbyte IsDelete { get; set; }
        public sbyte IsShow { get; set; }
        public sbyte IsTop { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
    }
}
