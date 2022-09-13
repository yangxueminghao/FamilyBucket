using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Paysalarypersonaltax
    {
        public Guid Pkid { get; set; }
        public Guid TaxInfoId { get; set; }
        public string CalendarId { get; set; }
        public int PersonId { get; set; }
        public string IdcardNumber { get; set; }
        public string Cyclename { get; set; }
        public string TaxCycle { get; set; }
        public int? TaxType { get; set; }
        public decimal? Salary { get; set; }
        public decimal? Sosum { get; set; }
        public decimal? Gjjsum { get; set; }
        public decimal? DeductSum { get; set; }
        public decimal? Threshold { get; set; }
        public decimal? Tax { get; set; }
        public decimal? YearBonusTax { get; set; }
        public decimal? RealSalary { get; set; }
        public decimal? DeductChild { get; set; }
        public decimal? DeductRent { get; set; }
        public decimal? DeductLoan { get; set; }
        public decimal? DeductOld { get; set; }
        public decimal? DeductEdu { get; set; }
        public decimal? ShouldTax { get; set; }
        public decimal? AlreadyTax { get; set; }
        public DateTime AddTime { get; set; }
    }
}
