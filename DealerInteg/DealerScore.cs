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
    
    public partial class DealerScore
    {
        public int ID { get; set; }
        public string Score { get; set; }
        public decimal DisAjd { get; set; }
        public decimal LTVCap { get; set; }
        public decimal MinDisc { get; set; }
        public int CreatedByID { get; set; }
        public int ModifiedByID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<int> Organization_ID { get; set; }
    }
}
