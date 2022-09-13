using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Rostercustomeragreement
    {
        public int Id { get; set; }
        public string AgreementName { get; set; }
        public string Version { get; set; }
        public sbyte IsEffect { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string FileUrl { get; set; }
    }
}
