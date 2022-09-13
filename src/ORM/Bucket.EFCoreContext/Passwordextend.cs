using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Passwordextend
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid UserId { get; set; }
        public int BusinessType { get; set; }
        public string Password { get; set; }
        public sbyte Isvaild { get; set; }
        public string Mobile { get; set; }
    }
}
