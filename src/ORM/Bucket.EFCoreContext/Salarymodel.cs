using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Salarymodel
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int Status { get; set; }
        public Guid? ModelGuid { get; set; }
        public Guid? UserId { get; set; }
        public Guid AddUser { get; set; }
        public DateTime AddTime { get; set; }
        public Guid? UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
