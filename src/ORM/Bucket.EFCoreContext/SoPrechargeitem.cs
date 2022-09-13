using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SoPrechargeitem
    {
        public string Id { get; set; }
        public Guid ItemId { get; set; }
        public Guid PrechargeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
