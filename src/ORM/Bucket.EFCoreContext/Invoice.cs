using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Invoice
    {
        public Guid InvoiceId { get; set; }
        public Guid UserId { get; set; }
        public string InvoiceApplyNumber { get; set; }
        public Guid InvoiceAddressId { get; set; }
        public decimal Amount { get; set; }
        public decimal BaseAmount { get; set; }
        public decimal ServiceAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public string SocialItemIdListJson { get; set; }
        public string OrderIdListJson { get; set; }
        public string OrderNumberListJson { get; set; }
        public int CheckStatus { get; set; }
        public DateTime? CheckTime { get; set; }
        public int IsCanceled { get; set; }
        public DateTime? CancelTime { get; set; }
        public decimal AmountCheck { get; set; }
        public decimal BaseAmountCheck { get; set; }
        public decimal ServiceAmountCheck { get; set; }
        public decimal TaxAmountCheck { get; set; }
        public int ApplyToHaoTianStatus { get; set; }
        public DateTime? ApplyTime { get; set; }
        public string ApplyInfoJson { get; set; }
        public string ApplyResultJson { get; set; }
        public string HaoTianInvoiceId { get; set; }
        public string HaoTianApplyNo { get; set; }
        public string ApplyResultMsg { get; set; }
        public DateTime? LatestFetchTime { get; set; }
        public int InvoiceStatus { get; set; }
        public string InvoiceStautsRemark { get; set; }
        public string InvoiceNumber { get; set; }
        public string MakeType { get; set; }
        public string DownloadUrl { get; set; }
        public string ExpressType { get; set; }
        public string ExpressNo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int TimeToken { get; set; }
        public string CheckRemarks { get; set; }
        public int IsRedApply { get; set; }
        public DateTime? RedApplyTime { get; set; }
        public string RedApplyInfoJson { get; set; }
        public string RedApplyResultJson { get; set; }
        public int IsRedApplySuccess { get; set; }
        public int BusType { get; set; }
        public decimal BaseHouseAmountCheck { get; set; }
        public decimal SocialBaseAmount { get; set; }
        public decimal HouseBaseAmount { get; set; }
        public string MakeUnitName { get; set; }
        public sbyte IsAgainInvoice { get; set; }
    }
}
