using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Rosterlaborcontract
    {
        public Guid ContractId { get; set; }
        public string ContractNo { get; set; }
        public string EmployeeName { get; set; }
        public string IdcardNumber { get; set; }
        public string Depart { get; set; }
        public string Position { get; set; }
        public string ContractPeriod { get; set; }
        public sbyte? IsFix { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ContractType { get; set; }
        public sbyte? IsFiresRenew { get; set; }
        public sbyte? IsSecondRenew { get; set; }
        public string CompanyWorkYear { get; set; }
        public sbyte? IsDna { get; set; }
        public sbyte? IsSalaryAffirm { get; set; }
        public sbyte? WorkContractAffirm { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime? EntryDate { get; set; }
        public string Phone { get; set; }
        public int? Sex { get; set; }
        public string Remark { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
