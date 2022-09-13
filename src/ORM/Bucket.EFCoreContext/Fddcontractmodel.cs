using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Fddcontractmodel
    {
        public Guid ModelId { get; set; }
        public string ModelName { get; set; }
        public string SealId { get; set; }
        public sbyte IsBand { get; set; }
        public int BusType { get; set; }
        public string ModelUrl { get; set; }
        public DateTime? AddTime { get; set; }
        public string AddUser { get; set; }
        public string TemplateId { get; set; }
        public string Remark { get; set; }
        public string Version { get; set; }
        public string ModelUrlHtml { get; set; }
    }
}
