using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SoInjuryandbirth
    {
        public int Id { get; set; }
        public string ExpensesSource { get; set; }
        public string ApplyNumber { get; set; }
        public string ArrivalNumber { get; set; }
        public string Receivables { get; set; }
        public string PaymentTime { get; set; }
        public int? MonthNumber { get; set; }
        public int? ApplyType { get; set; }
        public int? PayType { get; set; }
        public string CustomerName { get; set; }
        public string SupplierName { get; set; }
        public string AccountName { get; set; }
        public string BankNumber { get; set; }
        public string OpenProvince { get; set; }
        public string OpenCity { get; set; }
        public string OpenBank { get; set; }
        public string ContractPayDate { get; set; }
        public string BackTime { get; set; }
        public decimal? PayMoney { get; set; }
        public string Remark { get; set; }
        public string ApplyPerson { get; set; }
        public string AnnexAddress { get; set; }
        public sbyte IsApply { get; set; }
        public string FailMsg { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
