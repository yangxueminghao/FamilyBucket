using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Fddbaseinfo
    {
        public int InfoId { get; set; }
        public string CustomerId { get; set; }
        public sbyte IsAuth { get; set; }
        public string AuthNo { get; set; }
        public string AuthUrl { get; set; }
        public string VerifiedNo { get; set; }
        public string SignatureId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
