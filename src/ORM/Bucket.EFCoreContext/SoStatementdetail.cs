using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SoStatementdetail
    {
        public Guid DetailId { get; set; }
        public Guid StatementId { get; set; }
        public string Name { get; set; }
        public string IdCardNumber { get; set; }
        public string JoinMonth { get; set; }
        public string JoinCity { get; set; }
        public string Sstype { get; set; }
        public string ItemType { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? ServicePrice { get; set; }
        public decimal? SocialBase { get; set; }
        public decimal? SocialSumC { get; set; }
        public decimal? SocialSumP { get; set; }
        public decimal? SocialSum { get; set; }
        public decimal? AccBase { get; set; }
        public decimal? AccRateC { get; set; }
        public decimal? AccC { get; set; }
        public decimal? AccRateP { get; set; }
        public decimal? AccP { get; set; }
        public decimal? AccSum { get; set; }
        public decimal? EndowmentBase { get; set; }
        public decimal? EndowmentRateC { get; set; }
        public decimal? EndowmentAmountC { get; set; }
        public decimal? EndowmentRateP { get; set; }
        public decimal? EndowmentAmountP { get; set; }
        public decimal? MedicalBase { get; set; }
        public decimal? MedicalRateC { get; set; }
        public decimal? MedicalAmountC { get; set; }
        public decimal? MedicalRateP { get; set; }
        public decimal? MedicalAmountP { get; set; }
        public decimal? UnemployeementBase { get; set; }
        public decimal? UnemployeementRateC { get; set; }
        public decimal? UnemployeementAmountC { get; set; }
        public decimal? UnemployeementRateP { get; set; }
        public decimal? UnemployeementAmountP { get; set; }
        public decimal? AccidentBase { get; set; }
        public decimal? AccidentRateC { get; set; }
        public decimal? AccidentAmountC { get; set; }
        public decimal? BirthBase { get; set; }
        public decimal? BirthRateC { get; set; }
        public decimal? BirthAmountC { get; set; }
        public decimal? DeformityBase { get; set; }
        public decimal? DeformityRateC { get; set; }
        public decimal? DeformityAmountC { get; set; }
        public decimal? AddMedicalBase { get; set; }
        public decimal? AddMedicalRateC { get; set; }
        public decimal? AddMedicalAmountC { get; set; }
        public decimal? AddMedicalRateP { get; set; }
        public decimal? AddMedicalAmountP { get; set; }
        public decimal? Others { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
