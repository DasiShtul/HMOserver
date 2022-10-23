using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class VaccinationCommon
    {
        public int VaccinationId { get; set; }
        public Nullable<int> MakerId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<System.DateTime> VaccinationDate { get; set; }
        public Nullable<int> VaccinatioNumber { get; set; }
    }
}
