//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillingApplication.DBContexts
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImSS_Invoice_Master
    {
        public int ID { get; set; }
        public string Emp_Number { get; set; }
        public string PO_Number { get; set; }
        public Nullable<decimal> Contribution_Amount { get; set; }
        public string Engagement_Type { get; set; }
        public string Status { get; set; }
        public string YEAR { get; set; }
        public Nullable<long> Parent_Link_ID { get; set; }
        public Nullable<decimal> CarryForwardOrder { get; set; }
        public Nullable<decimal> Apr_Approved_Amount { get; set; }
        public Nullable<decimal> Apr_Invoiced_Amount { get; set; }
        public Nullable<decimal> May_Approved_Amount { get; set; }
        public Nullable<decimal> May_Invoiced_Amount { get; set; }
        public Nullable<decimal> Jun_Approved_Amount { get; set; }
        public Nullable<decimal> Jun_Invoiced_Amount { get; set; }
        public Nullable<decimal> Jul_Approved_Amount { get; set; }
        public Nullable<decimal> Jul_Invoiced_Amount { get; set; }
        public Nullable<decimal> Aug_Approved_Amount { get; set; }
        public Nullable<decimal> Aug_Invoiced_Amount { get; set; }
        public Nullable<decimal> Sep_Approved_Amount { get; set; }
        public Nullable<decimal> Sep_Invoiced_Amount { get; set; }
        public Nullable<decimal> Oct_Approved_Amount { get; set; }
        public Nullable<decimal> Oct_Invoiced_Amount { get; set; }
        public Nullable<decimal> Nov_Approved_Amount { get; set; }
        public Nullable<decimal> Nov_Invoiced_Amount { get; set; }
        public Nullable<decimal> Dec_Approved_Amount { get; set; }
        public Nullable<decimal> Dec_Invoiced_Amount { get; set; }
        public Nullable<decimal> Jan_Approved_Amount { get; set; }
        public Nullable<decimal> Jan_Invoiced_Amount { get; set; }
        public Nullable<decimal> Feb_Approved_Amount { get; set; }
        public Nullable<decimal> Feb_Invoiced_Amount { get; set; }
        public Nullable<decimal> Mar_Approved_Amount { get; set; }
        public Nullable<decimal> Mar_Invoiced_Amount { get; set; }
        public Nullable<decimal> Per_Day_Amount { get; set; }
    }
}
