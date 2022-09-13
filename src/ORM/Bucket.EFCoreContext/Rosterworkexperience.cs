using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Rosterworkexperience
    {
        public int Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string WorkUnit { get; set; }
        public string Position { get; set; }
        public DateTime? Tenure { get; set; }
        public DateTime? LeaveTime { get; set; }
        public string LeaveReason { get; set; }
        public sbyte IsDelete { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
