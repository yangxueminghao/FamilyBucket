using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Fddbustype
    {
        public int BusTypeId { get; set; }
        public string BusTypeName { get; set; }
        public DateTime? AddTime { get; set; }
        public int ContractType { get; set; }
        public string ApplicationId { get; set; }
        public int OrderIndex { get; set; }
        public sbyte IsActive { get; set; }
    }
}
