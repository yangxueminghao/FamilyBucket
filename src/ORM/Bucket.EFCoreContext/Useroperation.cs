using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Useroperation
    {
        public int Id { get; set; }
        public int UserLoginId { get; set; }
        public string ButtonId { get; set; }
        public string Url { get; set; }
        public string ButtonBusinessBus { get; set; }
        public int ClickTime { get; set; }
        public DateTime FirstClickDate { get; set; }
    }
}
