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
    
    public partial class PriceChangeEmailList
    {
        public int ID { get; set; }
        public Nullable<int> User { get; set; }
        public bool IsCC { get; set; }
    
        public virtual User User1 { get; set; }
    }
}
