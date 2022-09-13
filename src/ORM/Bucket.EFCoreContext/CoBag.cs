using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class CoBag
    {
        public string BagId { get; set; }
        public string BagName { get; set; }
        public sbyte IsLong { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int IssuedType { get; set; }
        public int? BagNumbers { get; set; }
        public int SendType { get; set; }
        public int? Condition { get; set; }
        public int SendObject { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public sbyte IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
