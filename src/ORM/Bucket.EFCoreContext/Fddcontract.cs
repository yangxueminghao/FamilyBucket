using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Fddcontract
    {
        public int ContractId { get; set; }
        public string ContractNum { get; set; }
        public string ContractName { get; set; }
        public string SignatureId { get; set; }
        public string SignatureName { get; set; }
        public int BusType { get; set; }
        public DateTime ContractStime { get; set; }
        public DateTime ContractEtime { get; set; }
        public int ContractStatus { get; set; }
        public int ContractType { get; set; }
        public string ContractUrl { get; set; }
        public string ContractViewUrl { get; set; }
        public DateTime? AddTime { get; set; }
        public Guid? UserId { get; set; }
        public int? ContractTypeName { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
