using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Paysalarybill
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string BillNo { get; set; }
        public string BillName { get; set; }
        public DateTime CreateTime { get; set; }
        public int PersonNum { get; set; }
        public decimal TotalPay { get; set; }
        public int Status { get; set; }
        public int PaySalaryId { get; set; }
        public int ValidDay { get; set; }
        public decimal ServerPay { get; set; }
        public string BillUrl { get; set; }
        public Guid? InvoiceId { get; set; }
        public decimal ActualPay { get; set; }
        public int? PersonCount { get; set; }
        public sbyte IsReissue { get; set; }
    }
}
