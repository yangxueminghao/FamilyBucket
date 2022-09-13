using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Refundorder
    {
        public int RowId { get; set; }
        public Guid RefundGuid { get; set; }
        public Guid OrderId { get; set; }
        public string OrderNumber { get; set; }
        public Guid SocialSecurityItemId { get; set; }
        public Guid UserId { get; set; }
        public int RefundStatus { get; set; }
        public Guid? AddAdminUser { get; set; }
        public DateTime DateCreate { get; set; }
        public Guid? RefundAdminUser { get; set; }
        public DateTime? DateRefund { get; set; }
        public decimal RefundAmount { get; set; }
        public int RefundType { get; set; }
        public string RefundRemark { get; set; }
        public Guid? InvoiceId { get; set; }
        public int? IsRefundServiceFees { get; set; }
    }
}
