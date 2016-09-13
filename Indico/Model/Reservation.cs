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
    
    public partial class Reservation
    {
        public Reservation()
        {
            this.Orders = new HashSet<Order>();
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int ID { get; set; }
        public int ReservationNo { get; set; }
        public System.DateTime OrderDate { get; set; }
        public Nullable<int> Pattern { get; set; }
        public int Coordinator { get; set; }
        public int Distributor { get; set; }
        public string Client { get; set; }
        public Nullable<int> ShipTo { get; set; }
        public Nullable<int> ShipmentMode { get; set; }
        public System.DateTime ShipmentDate { get; set; }
        public int Qty { get; set; }
        public string Notes { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
        public int Creator { get; set; }
        public int Modifier { get; set; }
        public int Status { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual DistributorClientAddress DistributorClientAddress { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Pattern Pattern1 { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual ShipmentMode ShipmentMode1 { get; set; }
        public virtual ReservationStatu ReservationStatu { get; set; }
    }
}
