//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Indico.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            this.FactoryOrderDetials = new HashSet<FactoryOrderDetial>();
            this.InvoiceOrders = new HashSet<InvoiceOrder>();
            this.OrderDetailQties = new HashSet<OrderDetailQty>();
            this.PackingLists = new HashSet<PackingList>();
            this.ProductionPlannings = new HashSet<ProductionPlanning>();
        }
    
        public int ID { get; set; }
        public int OrderType { get; set; }
        public Nullable<int> VisualLayout { get; set; }
        public int Pattern { get; set; }
        public int FabricCode { get; set; }
        public string VisualLayoutNotes { get; set; }
        public string NameAndNumbersFilePath { get; set; }
        public int Order { get; set; }
        public Nullable<int> Status { get; set; }
        public System.DateTime ShipmentDate { get; set; }
        public System.DateTime SheduledDate { get; set; }
        public bool IsRepeat { get; set; }
        public System.DateTime RequestedDate { get; set; }
        public Nullable<decimal> EditedPrice { get; set; }
        public string EditedPriceRemarks { get; set; }
        public Nullable<int> Reservation { get; set; }
        public Nullable<bool> PhotoApprovalReq { get; set; }
        public Nullable<bool> IsRequiredNamesNumbers { get; set; }
        public bool IsBrandingKit { get; set; }
        public bool IsLockerPatch { get; set; }
        public Nullable<int> ArtWork { get; set; }
        public Nullable<int> Label { get; set; }
        public Nullable<int> PaymentMethod { get; set; }
        public Nullable<int> ShipmentMode { get; set; }
        public Nullable<bool> IsWeeklyShipment { get; set; }
        public Nullable<bool> IsCourierDelivery { get; set; }
        public Nullable<int> DespatchTo { get; set; }
        public string PromoCode { get; set; }
        public string FactoryInstructions { get; set; }
        public decimal Surcharge { get; set; }
    
        public virtual ArtWork ArtWork1 { get; set; }
        public virtual DistributorClientAddress DistributorClientAddress { get; set; }
        public virtual FabricCode FabricCode1 { get; set; }
        public virtual ICollection<FactoryOrderDetial> FactoryOrderDetials { get; set; }
        public virtual ICollection<InvoiceOrder> InvoiceOrders { get; set; }
        public virtual Label Label1 { get; set; }
        public virtual Order Order1 { get; set; }
        public virtual OrderType OrderType1 { get; set; }
        public virtual Pattern Pattern1 { get; set; }
        public virtual PaymentMethod PaymentMethod1 { get; set; }
        public virtual Reservation Reservation1 { get; set; }
        public virtual ShipmentMode ShipmentMode1 { get; set; }
        public virtual OrderDetailStatu OrderDetailStatu { get; set; }
        public virtual VisualLayout VisualLayout1 { get; set; }
        public virtual ICollection<OrderDetailQty> OrderDetailQties { get; set; }
        public virtual ICollection<PackingList> PackingLists { get; set; }
        public virtual ICollection<ProductionPlanning> ProductionPlannings { get; set; }
    }
}
