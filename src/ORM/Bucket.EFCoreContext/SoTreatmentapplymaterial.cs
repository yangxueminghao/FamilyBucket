using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SoTreatmentapplymaterial
    {
        public Guid DetailId { get; set; }
        public Guid ApplyId { get; set; }
        public string Name { get; set; }
        public string Require { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        public string Instructions { get; set; }
        public string SampleAttach { get; set; }
        public string EmptySampleAttach { get; set; }
        public int DataType { get; set; }
        public int MaterialType { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
        public string UploadAttach { get; set; }
    }
}
