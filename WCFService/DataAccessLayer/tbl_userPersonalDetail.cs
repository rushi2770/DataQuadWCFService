//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFService.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_userPersonalDetail
    {
        public int id { get; set; }
        public string Gender { get; set; }
        public string Ethnicity { get; set; }
        public string Race { get; set; }
        public string TechnologyIntersted { get; set; }
        public Nullable<int> userId { get; set; }
    
        public virtual tbl_userDetails tbl_userDetails { get; set; }
    }
}