using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Rostercustomerdata
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public Guid CustomerId { get; set; }
        public string Version { get; set; }
        public DateTime EffectTime { get; set; }
        public DateTime FinishTime { get; set; }
        public DateTime ReadTime { get; set; }
        public int Status { get; set; }
        public int AgreementId { get; set; }
    }
}
