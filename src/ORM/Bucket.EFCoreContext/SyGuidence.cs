using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SyGuidence
    {
        public Guid Id { get; set; }
        public string TerminalType { get; set; }
        public string ApplicationId { get; set; }
        public int OrderNumber { get; set; }
        public string PicUrl { get; set; }
        public string LeadingWords { get; set; }
        public sbyte? IsDelete { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string Title { get; set; }
        public string PicLocation { get; set; }
        public string PopupLocation { get; set; }
    }
}
