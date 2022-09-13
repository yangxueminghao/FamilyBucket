using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SoTreatmentapplyinfo
    {
        public Guid Id { get; set; }
        public string ApplyNumber { get; set; }
        public string Name { get; set; }
        public string IdCard { get; set; }
        public string Mobile { get; set; }
        public string City { get; set; }
        public int ApplyType { get; set; }
        public string Remark { get; set; }
        public string CostCenterId { get; set; }
        public string Onditions { get; set; }
        public string ProcessingProcess { get; set; }
        public string OtherConditions { get; set; }
        public int Status { get; set; }
        public int PayStatus { get; set; }
        public string FailMsg { get; set; }
        public DateTime? ApplyDeadline { get; set; }
        public string ExchangeNo { get; set; }
        public int? ToFynStatus { get; set; }
        public string ToFynResult { get; set; }
        public Guid UserId { get; set; }
        public sbyte IsDelete { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
