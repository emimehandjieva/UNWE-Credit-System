//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LearningCreditSystem.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROD_PERIODS
    {
        public PROD_PERIODS()
        {
            this.INTEREST = new HashSet<INTEREST>();
        }
    
        public int PROD_CODE { get; set; }
        public int PROD_PERIOD { get; set; }
    
        public virtual CREDIT_PRODUCT CREDIT_PRODUCT { get; set; }
        public virtual ICollection<INTEREST> INTEREST { get; set; }
    }
}