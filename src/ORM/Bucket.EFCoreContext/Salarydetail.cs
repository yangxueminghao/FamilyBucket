using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Salarydetail
    {
        public int Id { get; set; }
        public ulong Back { get; set; }
        public ulong? Check { get; set; }
        public ulong? Sure { get; set; }
        public ulong? SendWx { get; set; }
        public ulong? SendEmail { get; set; }
        public ulong? SendMobile { get; set; }
        public int RecordId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeMobile { get; set; }
        public string Email { get; set; }
        public decimal TotalPay { get; set; }
        public decimal Deduction { get; set; }
        public decimal ActualSalary { get; set; }
        public string Remark { get; set; }
        public string Detail { get; set; }
        public Guid AddUser { get; set; }
        public DateTime AddTime { get; set; }
        public Guid? UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? CheckTime { get; set; }
        public DateTime? SureTime { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? SendTime { get; set; }
        public int? SendStatus { get; set; }
        public string SendTypeSign { get; set; }
    }
}
