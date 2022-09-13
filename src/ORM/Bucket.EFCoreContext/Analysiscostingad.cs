using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Analysiscostingad
    {
        public int Id { get; set; }
        public string TerminalType { get; set; }
        public string AttendBusiness { get; set; }
        public string SourceChannel { get; set; }
        public string SpecificSource { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ManualInputExposure { get; set; }
        public int? ManualInputClick { get; set; }
        public int? SumInquired { get; set; }
        public int? SumSignUp { get; set; }
    }
}
