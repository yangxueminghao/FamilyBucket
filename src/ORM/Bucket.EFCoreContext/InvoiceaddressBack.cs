using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class InvoiceaddressBack
    {
        public Guid RowId { get; set; }
        public Guid UserId { get; set; }
        public string CompanyName { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Reception { get; set; }
        public string ReceiverName { get; set; }
        public string Mobile { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int? Status { get; set; }

        public virtual User User { get; set; }
    }
}
