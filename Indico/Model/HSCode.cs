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
    
    public partial class HSCode
    {
        public int ID { get; set; }
        public int ItemSubCategory { get; set; }
        public int Gender { get; set; }
        public string Code { get; set; }
    
        public virtual Gender Gender1 { get; set; }
        public virtual Item Item { get; set; }
    }
}
