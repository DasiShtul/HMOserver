//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vaccination_tbl
    {
        public int VaccinationId { get; set; }
        public Nullable<int> MakerId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<System.DateTime> VaccinationDate { get; set; }
        public Nullable<int> VaccinatioNumber { get; set; }
    
        public virtual Maker_tbl Maker_tbl { get; set; }
        public virtual Patients_tbl Patients_tbl { get; set; }
    }
}
