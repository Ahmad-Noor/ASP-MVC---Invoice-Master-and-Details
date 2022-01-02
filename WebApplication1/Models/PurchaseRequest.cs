﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;

    public partial class PurchaseRequest
    { 
        public int id { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string PurchaseRequest_No { get; set; }
        public string Status { get; set; }
        public bool IsIntegrated { get; set; }
        public string ProponentRepresentative { get; set; }
        public Nullable<int> RequirementType_id { get; set; }
        public string Department_id { get; set; }
        public string CostCenter_id { get; set; }
        public Nullable<int> PurchaseRequestTypes_id { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string DeliveryPlace { get; set; }
        public string Justification { get; set; }
        public string Currency_id { get; set; }
        public string ProcurementCategory_id { get; set; }
        public Nullable<System.DateTime> ProcurementCategory_Date { get; set; }
        public Nullable<int> ConcurredbyFinance_id { get; set; }
        public Nullable<System.DateTime> ConcurredbyFinance_Date { get; set; }
        public Nullable<int> ApprovedbytheSite_id { get; set; }
        public Nullable<System.DateTime> ApprovedbytheSite_Date { get; set; }
        public Nullable<int> ConcurredbyProcurement_id { get; set; }
        public Nullable<System.DateTime> ConcurredbyProcurement_Date { get; set; }
        public Nullable<int> HeadOfDepartmenApproval_id { get; set; }
        public Nullable<System.DateTime> HeadOfDepartmenApproval_Date { get; set; }
        public string AttachmentFile { get; set; }
        public string Model1 { get; set; }
        public string Model2 { get; set; }
        public string Model3 { get; set; }
        public string Model4 { get; set; }
        public string Model5 { get; set; }
        public string Model6 { get; set; }
        public string Notes { get; set; }
        public string Name { get; set; }
        public string Project_id { get; set; }

     
    }
}
