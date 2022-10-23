using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public partial class Vaccination_tbl
    {
        public VaccinationCommon ConvertToCommon(Vaccination_tbl _Vaccination)
        {
            VaccinationCommon vaccinationCommon = new VaccinationCommon();
            vaccinationCommon.PatientId = _Vaccination.PatientId;
            vaccinationCommon.MakerId = _Vaccination.MakerId;
            vaccinationCommon.VaccinationId = _Vaccination.VaccinationId;
            vaccinationCommon.VaccinationDate = _Vaccination.VaccinationDate;
            vaccinationCommon.VaccinatioNumber = _Vaccination.VaccinatioNumber;

            return vaccinationCommon;
        }

        public static Vaccination_tbl ConvertFromCommon(VaccinationCommon vaccinationCommon)
        {
            Vaccination_tbl v_tbl = new Vaccination_tbl();
            v_tbl.PatientId =     vaccinationCommon.PatientId;
            v_tbl.MakerId = vaccinationCommon.MakerId;
            v_tbl.VaccinationId = vaccinationCommon.VaccinationId;
            v_tbl.VaccinationDate = vaccinationCommon.VaccinationDate;
            v_tbl.VaccinatioNumber = vaccinationCommon.VaccinatioNumber;
            return v_tbl;
        }
    }
}
