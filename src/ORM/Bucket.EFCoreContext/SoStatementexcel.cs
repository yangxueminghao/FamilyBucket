using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SoStatementexcel
    {
        public Guid Id { get; set; }
        public Guid? StatementId { get; set; }
        public string City { get; set; }
        public int? PersonNumber { get; set; }
        public decimal? SocialCompany { get; set; }
        public decimal? SocialPerson { get; set; }
        public decimal? AccumulationCompany { get; set; }
        public decimal? AccumulationPerson { get; set; }
        public decimal? ServicePrice { get; set; }
        public decimal? PreChargeAmount { get; set; }
        public decimal? SettlementAmount { get; set; }
        public int? AttendSocialNumber { get; set; }
        public decimal? EntServicePrice { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public byte IsDelete { get; set; }
    }
}
