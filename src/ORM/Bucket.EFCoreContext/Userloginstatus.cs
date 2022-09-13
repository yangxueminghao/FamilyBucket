using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Userloginstatus
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int Status { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime? LogoutDate { get; set; }
        public string PrivateUserId { get; set; }
        public string TerminalType { get; set; }
        public string LoginType { get; set; }
        public string SessionId { get; set; }
        public string Ipaddress { get; set; }
    }
}
