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
    
    public partial class DistributorClientAddress
    {
        public DistributorClientAddress()
        {
            this.Invoices = new HashSet<Invoice>();
            this.Invoices1 = new HashSet<Invoice>();
            this.Orders = new HashSet<Order>();
            this.Orders1 = new HashSet<Order>();
            this.OrderDetails = new HashSet<OrderDetail>();
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int ID { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public int Country { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string CompanyName { get; set; }
        public string State { get; set; }
        public Nullable<int> Port { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<int> AddressType { get; set; }
        public Nullable<int> Client { get; set; }
        public bool IsAdelaideWarehouse { get; set; }
        public Nullable<int> Distributor { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Country Country1 { get; set; }
        public virtual DestinationPort DestinationPort { get; set; }
        public virtual JobName JobName { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Invoice> Invoices1 { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Order> Orders1 { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
