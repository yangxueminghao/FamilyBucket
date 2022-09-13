using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SaGsgetmoneyinfo
    {
        public string GetId { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string Type { get; set; }
        public string GetMoneyNo { get; set; }
        public string CustomerId { get; set; }
        public string CustomerShort { get; set; }
        public DateTime? GetTime { get; set; }
        public DateTime? AddTime { get; set; }
        public decimal GetMoney { get; set; }
        public string Sremark { get; set; }
        public decimal NotCompleteMoney { get; set; }
        public string PaySideName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
