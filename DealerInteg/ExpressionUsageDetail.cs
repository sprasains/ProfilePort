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
    
    public partial class ExpressionUsageDetail
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public int ExecutionSequence { get; set; }
        public int CreatedByID { get; set; }
        public int ModifiedByID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<int> ExpressionCatalog_ID { get; set; }
        public Nullable<int> ExpressionUsage_ID { get; set; }
        public Nullable<int> Organization_ID { get; set; }
        public Nullable<int> ErrorUsage_ID { get; set; }
        public bool ErrorOnFailure { get; set; }
    
        public virtual ExpressionCatalog ExpressionCatalog { get; set; }
        public virtual ExpressionUsage ExpressionUsage { get; set; }
        public virtual ExpressionUsage ExpressionUsage1 { get; set; }
    }
}
