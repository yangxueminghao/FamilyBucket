using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Necessaryfiled
    {
        public int Id { get; set; }
        public Guid ReportingInformationId { get; set; }
        public string FieldName { get; set; }
        public int FieldType { get; set; }
        public string FieldContent { get; set; }
        public string Value { get; set; }
    }
}
