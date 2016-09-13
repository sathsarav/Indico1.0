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
    
    public partial class SPC_ViewPatternDetails_Result
    {
        public Nullable<int> ID { get; set; }
        public int Pattern { get; set; }
        public string Item { get; set; }
        public string SubItem { get; set; }
        public string Gender { get; set; }
        public string AgeGroup { get; set; }
        public string SizeSet { get; set; }
        public string CoreCategory { get; set; }
        public string PrinterType { get; set; }
        public string Number { get; set; }
        public string OriginRef { get; set; }
        public string NickName { get; set; }
        public string Keywords { get; set; }
        public string CorePattern { get; set; }
        public string FactoryDescription { get; set; }
        public string Consumption { get; set; }
        public decimal ConvertionFactor { get; set; }
        public string SpecialAttributes { get; set; }
        public string PatternNotes { get; set; }
        public string PriceRemarks { get; set; }
        public bool IsActive { get; set; }
        public int Creator { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int Modifier { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string Remarks { get; set; }
        public bool IsTemplate { get; set; }
        public int Parent { get; set; }
        public string GarmentSpecStatus { get; set; }
        public bool IsActiveWS { get; set; }
        public bool IsCoreRange { get; set; }
        public string HTSCode { get; set; }
        public decimal SMV { get; set; }
        public string MarketingDescription { get; set; }
        public Nullable<bool> PatternParent { get; set; }
        public Nullable<bool> Reservation { get; set; }
        public Nullable<bool> Price { get; set; }
        public Nullable<bool> PatternTemplateImage { get; set; }
        public Nullable<bool> Product { get; set; }
        public Nullable<bool> OrderDetail { get; set; }
        public Nullable<bool> VisualLayout { get; set; }
    }
}
