using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class XkEssencials
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Requirements { get; set; }
        public int? Quantity { get; set; }
        public string Format { get; set; }
        public int? Occations { get; set; }
        public string Sample { get; set; }
        public string EmptySample { get; set; }
        public string SampleName { get; set; }
        public string SampleType { get; set; }
        public string BranchId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
