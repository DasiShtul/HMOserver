using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public partial class Patients_tbl
    {
        public PatientsCommon ConvertToCommon(Patients_tbl _Patients)
        {
            PatientsCommon patientsCommon = new PatientsCommon();
            patientsCommon.ID = _Patients.ID;
            patientsCommon.FirstName = _Patients.FirstName;
            patientsCommon.LastName = _Patients.LastName;
            patientsCommon.City = _Patients.City;
            patientsCommon.Street = _Patients.Street;
            patientsCommon.HouseNumber = _Patients.HouseNumber;
            patientsCommon.Phone= _Patients.Phone;
            patientsCommon.MobilePhone= _Patients.MobilePhone;
            patientsCommon.DateOfBirth = _Patients.DateOfBirth;
            return patientsCommon;
        }

        public Patients_tbl ConvertFromCommon(PatientsCommon patientsCommon)
        {
            Patients_tbl p_tbl = new Patients_tbl();
            p_tbl.ID = patientsCommon.ID;
            p_tbl.FirstName = patientsCommon.FirstName;
            p_tbl.LastName = patientsCommon.LastName;
            p_tbl.City = patientsCommon.City;
            p_tbl.Street = patientsCommon.Street;
            p_tbl.HouseNumber = patientsCommon.HouseNumber;
            p_tbl.Phone = patientsCommon.Phone;
            p_tbl.MobilePhone = patientsCommon.MobilePhone;
            p_tbl.DateOfBirth = patientsCommon.DateOfBirth;
            return p_tbl;
        }

    }
}
