using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Salarydetailtemp
    {
        public int Id { get; set; }
        public string RecordName { get; set; }
        public string Month { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeMobile { get; set; }
        public string Email { get; set; }
        public decimal? TotalPay { get; set; }
        public decimal? Deduction { get; set; }
        public decimal? ActualSalary { get; set; }
        public string Remark { get; set; }
        public string Detail { get; set; }
        public Guid? AddUser { get; set; }
        public DateTime? AddTime { get; set; }
        public Guid? UserId { get; set; }
    }
}
