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
    
    public partial class CREDIT_PRODUCT
    {
        public CREDIT_PRODUCT()
        {
            this.CREDIT = new HashSet<CREDIT>();
            this.PROD_PERIODS = new HashSet<PROD_PERIODS>();
        }
    
        public int PROD_CODE { get; set; }
        public string PROD_NAME { get; set; }
        public string PROD_ACTIVE { get; set; }
        public decimal PROD_SUM_FROM { get; set; }
        public decimal PROD_SUM_TO { get; set; }
        public Nullable<System.DateTime> MODIF_DATE { get; set; }
    
        public virtual ICollection<CREDIT> CREDIT { get; set; }
        public virtual ICollection<PROD_PERIODS> PROD_PERIODS { get; set; }
    }
}
