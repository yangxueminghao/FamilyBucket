using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SoTreatmentcostcenter
    {
        public Guid Id { get; set; }
        public int HandbookId { get; set; }
        public string CostCenterId { get; set; }
        public string Recipient { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
