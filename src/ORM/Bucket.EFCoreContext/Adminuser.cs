using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Adminuser
    {
        public Guid RowId { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModifed { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string LastLoginIp { get; set; }
        public string MenuRowId { get; set; }
        public string UserAvatarUrl { get; set; }
    }
}
