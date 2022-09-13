﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Reportinginformation
    {
        public Guid Id { get; set; }
        public string AccountNo { get; set; }
        public int BusinessType { get; set; }
        public DateTime? ActiveTime { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string DossierReceiver { get; set; }
        public string ContactNumber { get; set; }
        public string ReceiveAddress { get; set; }
        public int FyId { get; set; }
    }
}
