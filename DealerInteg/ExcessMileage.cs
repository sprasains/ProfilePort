//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DealerPortalCRM
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExcessMileage
    {
        public int ID { get; set; }
        public int MinMileage { get; set; }
        public int MaxMileage { get; set; }
        public decimal LTVAdj { get; set; }
        public decimal DiscAdj { get; set; }
        public decimal TermCap { get; set; }
        public int CreatedByID { get; set; }
        public int ModifiedByID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> Organization_ID { get; set; }
    }
}
