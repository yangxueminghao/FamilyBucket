using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Salaryorder
    {
        public string Id { get; set; }
        public string OrderNum { get; set; }
        public Guid UserId { get; set; }
        public string MealId { get; set; }
        public decimal OrderPrice { get; set; }
        public DateTime CreateTime { get; set; }
        public int PayType { get; set; }
        public int PayStatu { get; set; }
        public string PayFail { get; set; }
        public int CheckStatus { get; set; }
        public sbyte IsValid { get; set; }
        public DateTime? PayTime { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime ContractReadTime { get; set; }
        public string ContractId { get; set; }
        public Guid InvoiceId { get; set; }
    }
}
