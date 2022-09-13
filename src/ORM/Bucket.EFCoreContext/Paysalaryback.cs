using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Paysalaryback
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public Guid BillId { get; set; }
        public Guid UserId { get; set; }
        public string ClientName { get; set; }
        public string ApplyId { get; set; }
        public string ApplyJson { get; set; }
        public string ApplyResult { get; set; }
        public DateTime? TaxTime { get; set; }
        public DateTime? ReturnMoneyTime { get; set; }
        public sbyte IsReissue { get; set; }
    }
}
