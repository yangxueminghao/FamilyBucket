using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Salaryrecord
    {
        public int Id { get; set; }
        public string RecordName { get; set; }
        public decimal? TotalSalary { get; set; }
        public int? Count { get; set; }
        public DateTime? SendTime { get; set; }
        public string Month { get; set; }
        public sbyte? IsShowNull { get; set; }
        public int? CheckedCount { get; set; }
        public Guid? ModelGuid { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int Type { get; set; }
        public string SalaryId { get; set; }
    }
}
