//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACHSystem.EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSchedule
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int FacilityID { get; set; }
        public int EmployeeID { get; set; }
    
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual tblFacility tblFacility { get; set; }
    }
}
