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
    
    public partial class SPC_GetOrderDetailIndicoPrice_Result
    {
        public int ID { get; set; }
        public int OrderDetail { get; set; }
        public string OrderType { get; set; }
        public string VisualLayout { get; set; }
        public Nullable<int> VisualLayoutID { get; set; }
        public Nullable<int> ArtWorkID { get; set; }
        public string Pattern { get; set; }
        public int PatternID { get; set; }
        public int FabricID { get; set; }
        public int Distributor { get; set; }
        public string Fabric { get; set; }
        public string VisualLayoutNotes { get; set; }
        public int Order { get; set; }
        public Nullable<int> Label { get; set; }
        public string Status { get; set; }
        public Nullable<int> StatusID { get; set; }
        public System.DateTime ShipmentDate { get; set; }
        public System.DateTime SheduledDate { get; set; }
        public bool IsRepeat { get; set; }
        public System.DateTime RequestedDate { get; set; }
        public Nullable<decimal> EditedPrice { get; set; }
        public string EditedPriceRemarks { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> EditedIndicoPrice { get; set; }
        public Nullable<decimal> TotalIndicoPrice { get; set; }
        public decimal Surcharge { get; set; }
    }
}
