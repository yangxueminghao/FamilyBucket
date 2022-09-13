using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Paysalaryperson
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string BankCardId { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public decimal Money { get; set; }
        public string TaxInfo { get; set; }
        public int BackId { get; set; }
        public int PayStatus { get; set; }
        public string HaoTianResult { get; set; }
        public string IdcardNumber { get; set; }
        public sbyte IsDelete { get; set; }
        public Guid BillId { get; set; }
        public string BankAccountName { get; set; }
        public string Email { get; set; }
    }
}
