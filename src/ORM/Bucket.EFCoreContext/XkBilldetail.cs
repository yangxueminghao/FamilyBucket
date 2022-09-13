using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class XkBilldetail
    {
        public string DetailId { get; set; }
        public Guid BillId { get; set; }
        public string Name { get; set; }
        public string SocialNo { get; set; }
        public string AccNo { get; set; }
        public string IdCard { get; set; }
        public decimal? Total { get; set; }
        public decimal? AccBaseNum { get; set; }
        public decimal? AccCompanyPercent { get; set; }
        public decimal? AccPersonPercent { get; set; }
        public decimal? CompanyTotal { get; set; }
        public decimal? PersonalTotal { get; set; }
        public int? Type { get; set; }
        public int? JoinType { get; set; }
        public DateTime StartMonth { get; set; }
        public DateTime EndMonth { get; set; }
        public string MemberType { get; set; }
        public decimal? TotalOverduefee { get; set; }
        public decimal? TotalInterest { get; set; }
        public decimal? UnemploymentNumber { get; set; }
        public decimal? EnterpriseUnemploymentMoney { get; set; }
        public decimal? PersonalUnemploymentMoney { get; set; }
        public decimal? UnemploymentInterest { get; set; }
        public decimal? UnemploymentOverduefee { get; set; }
        public decimal? MedicalNumber { get; set; }
        public decimal? EnterpriseMedicalMoney { get; set; }
        public decimal? PersonalMedicalMoney { get; set; }
        public decimal? MedicalInterest { get; set; }
        public decimal? MedicalOverduefee { get; set; }
        public decimal? OccupationalNumber { get; set; }
        public decimal? EnterpriseOccupationalMoney { get; set; }
        public decimal? PersonalOccupationalMoney { get; set; }
        public decimal? OccupationalInterest { get; set; }
        public decimal? OccupationalOverduefee { get; set; }
        public decimal? BearNumber { get; set; }
        public decimal? EnterpriseBearMoney { get; set; }
        public decimal? PersonalBearMoney { get; set; }
        public decimal? BearInterest { get; set; }
        public decimal? BearOverduefee { get; set; }
        public decimal? IllnessNumber { get; set; }
        public decimal? EnterpriseIllnessMoney { get; set; }
        public decimal? PersonalIllnessMoney { get; set; }
        public decimal? IllnessInterest { get; set; }
        public decimal? IllnessOverduefee { get; set; }
        public decimal? AnnuityNumber { get; set; }
        public decimal? EnterpriseAnnuityMoney { get; set; }
        public decimal? PersonalAnnuityMoney { get; set; }
        public decimal? AnnuityInterest { get; set; }
        public decimal? AnnuityOverduefee { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
