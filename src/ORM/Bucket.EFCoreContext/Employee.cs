using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Employee
    {
        public Guid EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string IdcardType { get; set; }
        public string IdcardNumber { get; set; }
        public string EmployeeSex { get; set; }
        public DateTime? EmployeeBirth { get; set; }
        public string MaritalStatus { get; set; }
        public string Nation { get; set; }
        public string PoliticalAppearance { get; set; }
        public string NativePlace { get; set; }
        public string Education { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string NowAddress { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyContactRelationship { get; set; }
        public string EmergencyContactWay { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public string EmployeeType { get; set; }
        public string EmployeeStatus { get; set; }
        public DateTime? CorrectionDate { get; set; }
        public string WorkCity { get; set; }
        public string DepartMent { get; set; }
        public string Post { get; set; }
        public string JobNumber { get; set; }
        public string IncumbencyStatus { get; set; }
        public string BankAccount { get; set; }
        public string WageCardNumber { get; set; }
        public string OpeningBank { get; set; }
        public string OpeningProvince { get; set; }
        public string OpeningCity { get; set; }
        public string SocialSecuirtyComputerNo { get; set; }
        public string GjjcardNo { get; set; }
        public string HouseholdRegisterType { get; set; }
        public string HouseholdRegisterAddress { get; set; }
        public string EnclosureUrl { get; set; }
        public Guid? AddUserId { get; set; }
        public Guid? UpdateUserId { get; set; }
        public DateTime? AddDateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string LeaveType { get; set; }
        public Guid UserId { get; set; }
    }
}
