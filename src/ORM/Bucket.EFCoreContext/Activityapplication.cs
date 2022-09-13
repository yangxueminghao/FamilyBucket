using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Activityapplication
    {
        public int Id { get; set; }
        public Guid ApplicationId { get; set; }
        public string CompanyName { get; set; }
        public string Mobile { get; set; }
        public string CompanyPhone { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string AttendBusiness { get; set; }
        public string AttendUrl { get; set; }
        public string PlatformType { get; set; }
        public sbyte IsEffective { get; set; }
        public string SoureChannel { get; set; }
        public string SpecificSource { get; set; }
    }
}
