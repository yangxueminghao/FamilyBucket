using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class WeAddress
    {
        public string Id { get; set; }
        public Guid? EmployeeId { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Town { get; set; }
        public string DetailAddress { get; set; }
        public sbyte IsDefault { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
