using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Adminmenu
    {
        public int RowId { get; set; }
        public Guid MenuId { get; set; }
        public string MenuName { get; set; }
        public Guid? MenuParentId { get; set; }
        public string MenuUrl { get; set; }
        public int? MenuOrder { get; set; }
        public int? MenuEnable { get; set; }
        public string MenuDiscription { get; set; }
        public DateTime? MenuTime { get; set; }
        public int? MenuLevel { get; set; }
    }
}
