using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class EsTask
    {
        public string TaskId { get; set; }
        public string TaskName { get; set; }
        public string TempId { get; set; }
        public string TempContent { get; set; }
        public string Subject { get; set; }
        public string Abstract { get; set; }
        public string SendAddress { get; set; }
        public string Sender { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? PlanSendTime { get; set; }
        public DateTime? SendTime { get; set; }
        public int Status { get; set; }
        public string Remark { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
