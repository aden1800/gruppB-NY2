//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gruppBNY.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class languages
    {
        public int languages_Id { get; set; }
        public string languages1 { get; set; }
        public Nullable<int> freelancer_id { get; set; }
    
        public virtual Freelancer Freelancer { get; set; }
    }
}
