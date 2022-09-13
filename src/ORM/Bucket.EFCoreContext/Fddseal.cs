using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Fddseal
    {
        public int SealId { get; set; }
        public string SealName { get; set; }
        public string SignatureId { get; set; }
        public string SealUrl { get; set; }
        public DateTime? AddTime { get; set; }
        public string AddUser { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
