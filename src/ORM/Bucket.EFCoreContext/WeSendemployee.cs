using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class WeSendemployee
    {
        public string EmployeeId { get; set; }
        public string OrderItemId { get; set; }
        public string EmployeeName { get; set; }
        public string Mobile { get; set; }
        public sbyte IsSend { get; set; }
        public sbyte IsReceive { get; set; }
        public sbyte IsCancel { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
        public Guid UserId { get; set; }
        public int? Indate { get; set; }
    }
}
