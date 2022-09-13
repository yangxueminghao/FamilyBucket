using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Followresult
    {
        public int Id { get; set; }
        public Guid ApplicationId { get; set; }
        public DateTime? DateCreate { get; set; }
        public int IntentionLevel { get; set; }
        public string Remark { get; set; }
    }
}
