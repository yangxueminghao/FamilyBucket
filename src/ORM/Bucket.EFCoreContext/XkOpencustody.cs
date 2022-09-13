using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class XkOpencustody
    {
        public Guid Id { get; set; }
        public Guid? AccountId { get; set; }
        public string WaterBillNo { get; set; }
        public int? OperationType { get; set; }
        public string ServiceBranchsId { get; set; }
        public int? BusinessType { get; set; }
        public decimal? ServiceFee { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverMobile { get; set; }
        public string ReceiverAddress { get; set; }
        public string BillDate { get; set; }
        public string ReductionDate { get; set; }
        public string WriteOffDate { get; set; }
        public sbyte? IsActive { get; set; }
        public string FyorderNo { get; set; }
        public int? Status { get; set; }
        public int? FyresultStatus { get; set; }
        public string ExpressNo { get; set; }
        public string MobileTail { get; set; }
        public sbyte? IsCancel { get; set; }
        public DateTime? CancelDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public sbyte IsDelete { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Ukey { get; set; }
        public decimal? EnterprisePercent { get; set; }
        public decimal? PersonPercent { get; set; }
        public string AddDeadline { get; set; }
        public string ReduceDeadline { get; set; }
        public sbyte? IsLock { get; set; }
        public string Remark { get; set; }
    }
}
