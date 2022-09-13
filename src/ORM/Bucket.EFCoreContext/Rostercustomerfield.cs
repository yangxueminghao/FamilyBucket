using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Rostercustomerfield
    {
        public int Id { get; set; }
        public Guid CompanyId { get; set; }
        public int Moduel { get; set; }
        public int FieldLocation { get; set; }
        public string FieldName { get; set; }
        public sbyte? IsDelete { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public sbyte IsShow { get; set; }
    }
}
