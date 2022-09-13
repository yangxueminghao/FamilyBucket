using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class WeEmployeeorder
    {
        public string OrderId { get; set; }
        public int OrderType { get; set; }
        public string FestivalId { get; set; }
        public string MealId { get; set; }
        public string SendEmployeeId { get; set; }
        public string CommodityCode { get; set; }
        public decimal? CommodityPrice { get; set; }
        public string CommodityAttribute { get; set; }
        public string ReceiveName { get; set; }
        public string ReceivePhone { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Town { get; set; }
        public string DetailAddress { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
        public string SerialNumber { get; set; }
        public string OrderCode { get; set; }
        public DateTime? OrderTime { get; set; }
        public string ApplyJson { get; set; }
        public string ReturnJson { get; set; }
        public string ExpressNo { get; set; }
        public decimal? ExpressFee { get; set; }
        public string ExpressCompany { get; set; }
        public string ExpressInfo { get; set; }
        public sbyte? IsDelete { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string FynRemark { get; set; }
        public int? Quantity { get; set; }
    }
}
