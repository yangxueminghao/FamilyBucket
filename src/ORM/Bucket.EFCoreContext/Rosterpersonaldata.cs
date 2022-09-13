using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Rosterpersonaldata
    {
        public int Id { get; set; }
        public Guid EmployeeId { get; set; }
        public int Type { get; set; }
        public string ImgUrl { get; set; }
        public sbyte IsDelete { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
