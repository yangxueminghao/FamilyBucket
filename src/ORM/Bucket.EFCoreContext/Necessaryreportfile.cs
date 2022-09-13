using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Necessaryreportfile
    {
        public int Id { get; set; }
        public Guid ReportingInformationId { get; set; }
        public string FileName { get; set; }
        public int FileType { get; set; }
        public int FileCount { get; set; }
        public string FileRequest { get; set; }
        public string FileUrl { get; set; }
        public string EmptyFileUrl { get; set; }
        public string Value { get; set; }
    }
}
