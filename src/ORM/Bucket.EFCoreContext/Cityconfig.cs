using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Cityconfig
    {
        public Guid CityId { get; set; }
        public string CityName { get; set; }
        public decimal ServiceFee { get; set; }
        public decimal PreCharge { get; set; }
        public sbyte? IsOpen { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public sbyte IsDelete { get; set; }
        public decimal NewShemalServiceFee { get; set; }
    }
}
