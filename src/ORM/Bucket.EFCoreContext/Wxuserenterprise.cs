using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Wxuserenterprise
    {
        public int Id { get; set; }
        public string OpenId { get; set; }
        public string Phone { get; set; }
        public string Token { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string NickName { get; set; }
        public int? Sex { get; set; }
        public string Language { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string HeadImgUrl { get; set; }
        public string Remark { get; set; }
        public int IsDelete { get; set; }
    }
}
