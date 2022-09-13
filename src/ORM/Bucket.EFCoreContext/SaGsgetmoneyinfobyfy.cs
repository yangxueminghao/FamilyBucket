using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SaGsgetmoneyinfobyfy
    {
        public string GetId { get; set; }
        public string GetMoneyNo { get; set; }
        public string OldGetMoneyNo { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public DateTime? GetTime { get; set; }
        public string Customer { get; set; }
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public int? Item { get; set; }
        public decimal GetMoney { get; set; }
        public string PaySideName { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierShort { get; set; }
        public int? PayStatus { get; set; }
        public string Sremark { get; set; }
        public decimal NotCompleteMoney { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
