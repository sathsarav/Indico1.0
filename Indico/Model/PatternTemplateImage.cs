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
    
    public partial class PatternTemplateImage
    {
        public int ID { get; set; }
        public int Pattern { get; set; }
        public int Size { get; set; }
        public string Filename { get; set; }
        public string Extension { get; set; }
        public bool IsHero { get; set; }
        public Nullable<int> ImageOrder { get; set; }
    
        public virtual Pattern Pattern1 { get; set; }
    }
}
