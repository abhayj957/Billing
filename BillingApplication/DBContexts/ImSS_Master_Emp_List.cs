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
    
    public partial class ImSS_Master_Emp_List
    {
        public long ID { get; set; }
        public string Emp_Number { get; set; }
        public string Emp_Name { get; set; }
        public Nullable<System.DateTime> DOJ { get; set; }
        public Nullable<double> Previous_Exp { get; set; }
        public Nullable<double> ImSS_Exp { get; set; }
        public Nullable<double> Total_Exp { get; set; }
        public string Domain { get; set; }
        public string Business_Unit { get; set; }
        public string Reporting { get; set; }
        public string Primary_Skills { get; set; }
        public string Secondary_Skills { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string Mobile_Number { get; set; }
        public string Replaced_by { get; set; }
        public Nullable<System.DateTime> Relived_Date { get; set; }
    }
}
