using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Salaryprotocol
    {
        public string Id { get; set; }
        public string ProtocolName { get; set; }
        public int MealType { get; set; }
        public string Version { get; set; }
        public DateTime CreateDate { get; set; }
        public sbyte Isvaild { get; set; }
        public string Url { get; set; }
    }
}
