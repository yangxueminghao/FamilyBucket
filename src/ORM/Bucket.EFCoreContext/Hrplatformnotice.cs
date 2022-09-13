using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Hrplatformnotice
    {
        public int Id { get; set; }
        public string BusinessType { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime CreateTime { get; set; }
        public string OrderId { get; set; }
        public Guid UserId { get; set; }
    }
}
