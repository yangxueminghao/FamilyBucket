using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Rosterpersonalinfo
    {
        public Guid EmployeeId { get; set; }
        public string EnglishName { get; set; }
        public string Nation { get; set; }
        public DateTime? Birthday { get; set; }
        public int IdcardType { get; set; }
        public string IdcardNumber { get; set; }
        public int RegisterType { get; set; }
        public int Political { get; set; }
        public int MarryStatus { get; set; }
        public int HealthStatus { get; set; }
        public string DiseaseRemark { get; set; }
        public string Depart { get; set; }
        public string Position { get; set; }
        public string JobNumber { get; set; }
        public DateTime? TranDate { get; set; }
        public DateTime? TransDate { get; set; }
        public DateTime? FirstDate { get; set; }
        public int WorkNature { get; set; }
        public int EmployeeStatus { get; set; }
        public int Probation { get; set; }
        public string EmployeeExMail { get; set; }
        public string WorkAddress { get; set; }
        public int LastEducation { get; set; }
        public string SchoolName { get; set; }
        public string Professional { get; set; }
        public DateTime? FinishDate { get; set; }
        public string IdcardAddress { get; set; }
        public string CurrentAddress { get; set; }
        public DateTime? LeaveDate { get; set; }
        public int LeaveType { get; set; }
        public string LeaveMark { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
