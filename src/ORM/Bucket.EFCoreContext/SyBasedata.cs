using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SyBasedata
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
        public string Remark { get; set; }
        public sbyte IsParent { get; set; }
        public sbyte IsActive { get; set; }
        public sbyte IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
