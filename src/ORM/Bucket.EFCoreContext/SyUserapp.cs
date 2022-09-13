using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SyUserapp
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string ApplicationId { get; set; }
        public sbyte IsEnable { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string TerminalType { get; set; }
    }
}
