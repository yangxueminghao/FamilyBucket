using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class XkBill
    {
        public Guid BillId { get; set; }
        public Guid UserId { get; set; }
        public Guid? AccountId { get; set; }
        public int BusinessType { get; set; }
        public string BillNo { get; set; }
        public string BillName { get; set; }
        public DateTime CreateTime { get; set; }
        public decimal ServerPay { get; set; }
        public decimal TotalPay { get; set; }
        public int Status { get; set; }
        public DateTime? PayDateTime { get; set; }
        public sbyte IsInvoice { get; set; }
        public string InvoiceId { get; set; }
        public DateTime? SendTime { get; set; }
        public sbyte IsSendBill { get; set; }
        public int Count { get; set; }
        public string City { get; set; }
        public string Month { get; set; }
        public int BillType { get; set; }
        public DateTime? DateModified { get; set; }
        public int IsOtherFile { get; set; }
        public string OtherFile { get; set; }
    }
}
