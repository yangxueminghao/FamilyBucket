using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class EsTemplate
    {
        public string TempId { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string Remark { get; set; }
        public string Content { get; set; }
        public sbyte IsCommon { get; set; }
        public Guid? UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
