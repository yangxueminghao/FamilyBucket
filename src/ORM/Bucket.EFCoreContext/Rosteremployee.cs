using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Rosteremployee
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public int Sex { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public Guid CompanyId { get; set; }
        public sbyte IsDelete { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string Remark { get; set; }
    }
}
