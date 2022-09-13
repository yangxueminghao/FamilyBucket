using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Fddmodelparam
    {
        public int ParamId { get; set; }
        public string ParamName { get; set; }
        public Guid ModelId { get; set; }
        public string ParamKey { get; set; }
        public string TipText { get; set; }
        public int IsMustSet { get; set; }
        public int Sort { get; set; }
        public DateTime? AddTime { get; set; }
        public int ParamType { get; set; }
    }
}
