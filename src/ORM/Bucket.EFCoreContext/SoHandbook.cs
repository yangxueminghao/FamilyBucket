using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SoHandbook
    {
        public int Id { get; set; }
        public string PolicyTitle { get; set; }
        public string City { get; set; }
        public string CostCenterId { get; set; }
        public string WelfareClaimType { get; set; }
        public int Type { get; set; }
        public string Insurance { get; set; }
        public string DealLimit { get; set; }
        public int TagetPopulation { get; set; }
        public sbyte IsRecord { get; set; }
        public string RecordConditions { get; set; }
        public string RecordProcessingProcess { get; set; }
        public string RecordOtherConditions { get; set; }
        public sbyte IsConfirm { get; set; }
        public string ConfirmConditions { get; set; }
        public string ConfirmProcessingProcess { get; set; }
        public string ConfirmOtherConditions { get; set; }
        public string DealCondition { get; set; }
        public string DealProcess { get; set; }
        public string OtherRequire { get; set; }
        public sbyte IsPersonalHandle { get; set; }
        public string PersonalProcessingProcess { get; set; }
        public string PersonalHandlePlace { get; set; }
        public string PersonalOtherConditions { get; set; }
        public sbyte IsUnitHandle { get; set; }
        public string UnitProcessingProcess { get; set; }
        public string UnitHandlePlace { get; set; }
        public string UnitOtherConditions { get; set; }
        public sbyte IsTransferPersonal { get; set; }
        public string TransferPersonalMode { get; set; }
        public string SpecialInstructions { get; set; }
        public sbyte IsActive { get; set; }
        public DateTime? ApproveDate { get; set; }
        public int? ForceForwardTime { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
