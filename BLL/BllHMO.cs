using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using DAL;
using Common;


namespace BLL
{
    public class BllHMO
    {
        public static List<PatientsCommon> GetAllPatients()
        {
            return DalHMO.getAllPatients();
        }

        public static PatientsCommon getPatient(int _id)
        {
            return DalHMO.getPatient(_id);
        }

        public static List<StatusCOVID19Common> getAllStatusCOVID19()
        {
            return DalHMO.getAllStatusCOVID19();
        }

        public static List<VaccinationCommon> getAllVaccinations()
        {
            return DalHMO.getAllVaccination();
        }

        public static List<MakerCommon> getAllMakers()
        {
            return DalHMO.getAllMakers();
        }

        public static void DeletePatient(PatientsCommon item)
        {
            DalHMO.DeletePatient(item);
        }
        public static void AddPatient(PatientsCommon p)
        {
            DalHMO.AddPatient(p);
        }

        public static void UpdatePatient(int id, PatientsCommon p)
        {
            DalHMO.UpdatePatient(id, p);
        }
        }
}
