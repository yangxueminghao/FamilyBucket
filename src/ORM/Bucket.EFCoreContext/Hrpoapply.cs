using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Hrpoapply
    {
        public int Id { get; set; }
        public Guid ApplyGuid { get; set; }
        public int ApplyTypeId { get; set; }
        public Guid OrderItemId { get; set; }
        public DateTime ApplyDate { get; set; }
        public string ApplyNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int ApplyStatus { get; set; }
        public sbyte Posted { get; set; }
        public DateTime? PostedDate { get; set; }
        public int? IsCheck { get; set; }
        public DateTime? CheckDate { get; set; }
        public string CheckTor { get; set; }
        public string ResponseMsg { get; set; }
        public Guid MemmberId { get; set; }
        public Guid OrderId { get; set; }
    }
}
