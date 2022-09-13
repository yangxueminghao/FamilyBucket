using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Smsrecord
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string MobileNumber { get; set; }
        public string CityName { get; set; }
        public int NoticeType { get; set; }
        public int TimeToken { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? SendTime { get; set; }
        public string Email { get; set; }
        public int SmstitleType { get; set; }
        public string OrderNumber { get; set; }
        public string OpenId { get; set; }
    }
}
