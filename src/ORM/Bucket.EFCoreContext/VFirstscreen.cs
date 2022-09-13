using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class VFirstscreen
    {
        public string Id { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string TypeName { get; set; }
    }
}
