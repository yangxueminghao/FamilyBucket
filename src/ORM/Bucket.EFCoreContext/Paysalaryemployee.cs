using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Paysalaryemployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Idtype { get; set; }
        public string Idnumber { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public string OpenAccountName { get; set; }
        public sbyte IsOtherBank { get; set; }
        public string BankCardId { get; set; }
        public string TaxCity { get; set; }
        public Guid UserId { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Phone { get; set; }
        public string BankProvince { get; set; }
        public string BankCity { get; set; }
    }
}
