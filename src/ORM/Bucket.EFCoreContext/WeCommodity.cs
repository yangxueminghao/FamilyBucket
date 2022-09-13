using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class WeCommodity
    {
        public string CommodityId { get; set; }
        public DateTime DateCreated { get; set; }
        public int CommodityType { get; set; }
        public string CommodityCode { get; set; }
        public string CommodityName { get; set; }
        public string SupplierName { get; set; }
        public string CommodityBrandName { get; set; }
        public decimal CommodityPrice { get; set; }
        public decimal CommodityMarketPrice { get; set; }
        public string CommodityFaceValue { get; set; }
        public decimal CommodityStorage { get; set; }
        public int CommodityState { get; set; }
        public string CommodityDescription { get; set; }
        public string CommodityAttribute { get; set; }
        public string CommodityDistribution { get; set; }
        public string ChangeorRefund { get; set; }
        public string ReturnConditions { get; set; }
        public sbyte IsSellWell { get; set; }
        public string CommodityPictures { get; set; }
        public string CommodityCategory { get; set; }
        public int? Label { get; set; }
        public string GoodName { get; set; }
        public decimal? GoodPrice { get; set; }
        public int? CategoryId { get; set; }
        public sbyte? GoodStatus { get; set; }
        public DateTime? DateModified { get; set; }
        public int? PurchaseType { get; set; }
        public decimal? EnterprisePrice { get; set; }
    }
}
