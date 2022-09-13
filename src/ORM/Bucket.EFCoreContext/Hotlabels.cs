using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Hotlabels
    {
        public int Id { get; set; }
        public string LabelName { get; set; }
        public DateTime CreateTime { get; set; }
        public int? Status { get; set; }
        public sbyte IsOverHead { get; set; }
        public DateTime? ModifyOverHeadTime { get; set; }
        public string KeyWord { get; set; }
    }
}
