//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FindYourJob.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobApply
    {
        public int JobApplyID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> JobPostID { get; set; }
        public Nullable<System.DateTime> JobApplyDateTime { get; set; }
        public Nullable<int> JobApplyStatusID { get; set; }
        public Nullable<System.DateTime> StatusUpdateDateTime { get; set; }
        public string StatusUpdateReason { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual JobApplyStatu JobApplyStatu { get; set; }
        public virtual JobPost JobPost { get; set; }
    }
}
