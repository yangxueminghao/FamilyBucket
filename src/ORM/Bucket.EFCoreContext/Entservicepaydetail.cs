using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Entservicepaydetail
    {
        public int Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public string CityName { get; set; }
        public DateTime PayMonth { get; set; }
        public int InsureCount { get; set; }
        public decimal ServiceFee { get; set; }
        public sbyte Cancel { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
