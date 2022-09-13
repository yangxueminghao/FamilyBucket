using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class BaseCity
    {
        public int Id { get; set; }
        public string ProvinceName { get; set; }
        public string CityName { get; set; }
    }
}
