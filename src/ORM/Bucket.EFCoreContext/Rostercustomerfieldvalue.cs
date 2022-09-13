using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Rostercustomerfieldvalue
    {
        public int Id { get; set; }
        public int FieldId { get; set; }
        public string FieldValue { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int Moduel { get; set; }
        public Guid ModuelId { get; set; }
    }
}
