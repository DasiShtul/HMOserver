using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;
using Common;

namespace DAL
{
    public class DalHMO
    {
        public static List<PatientsCommon> getAllPatients()
        {
            try
            {
                using (DB_HMOEntities2 db = new DB_HMOEntities2())
                {
                    List<Patients_tbl> tbs = db.Patients_tbl.ToList();
                    return tbs.Select(x => x.ConvertToCommon(x)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static PatientsCommon getPatient(int _id)
        {
            try
            {
                using (DB_HMOEntities2 db = new DB_HMOEntities2())
                {
                    Patients_tbl tbs = db.Patients_tbl.Where(com => com.ID == _id).First();
                    return tbs.ConvertToCommon(tbs);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<MakerCommon> getAllMakers()
        {
            try
            {
                using (DB_HMOEntities2 db = new DB_HMOEntities2())
                {
                    List<Maker_tbl> tbs = db.Maker_tbl.ToList();
                    return tbs.Select(x => x.ConvertToCommon(x)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<VaccinationCommon> getAllVaccination()
        {
            try
            {
                using (DB_HMOEntities2 db = new DB_HMOEntities2())
                {
                    List<Vaccination_tbl> tbs = db.Vaccination_tbl.ToList();
                    return tbs.Select(x => x.ConvertToCommon(x)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<StatusCOVID19Common> getAllStatusCOVID19()
        {
            try
            {
                using (DB_HMOEntities2 db = new DB_HMOEntities2())
                {
                    List<StatusCOVID19_tbl> tbs = db.StatusCOVID19_tbl.ToList();
                    return tbs.Select(x => x.ConvertToCommon(x)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DeletePatient(PatientsCommon item)
        {
            try
            {
                using (DB_HMOEntities2 db = new DB_HMOEntities2())
                {
                    List<Vaccination_tbl> v = db.Vaccination_tbl.Where(com => com.PatientId == item.ID).ToList();
                    db.Vaccination_tbl.RemoveRange(v);
                    List<StatusCOVID19_tbl> s = db.StatusCOVID19_tbl.Where(com => com.PatientId == item.ID).ToList();
                    db.StatusCOVID19_tbl.RemoveRange(s);
                    List<Patients_tbl> p = db.Patients_tbl.Where(com => com.ID == item.ID).ToList();
                    db.Patients_tbl.RemoveRange(p);
                    db.SaveChanges();
                    List<StatusCOVID19_tbl> tbs = db.StatusCOVID19_tbl.ToList();
                    tbs.Select(x => x.ConvertToCommon(x)).ToList();
                    List<Patients_tbl> tbs1 = db.Patients_tbl.ToList();
                    tbs.Select(x => x.ConvertToCommon(x)).ToList();
                    List<Vaccination_tbl> tbs2 = db.Vaccination_tbl.ToList();
                    tbs.Select(x => x.ConvertToCommon(x)).ToList();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AddPatient(PatientsCommon p)
        {
            try
            {
                using (DB_HMOEntities2 db = new DB_HMOEntities2())
                {
                    Patients_tbl patients_ = new Patients_tbl();
                    patients_.ConvertFromCommon(p);
                    db.Patients_tbl.Add(patients_);
                    db.SaveChanges();
                    List<Patients_tbl> tbs = db.Patients_tbl.ToList();
                    tbs.Select(x => x.ConvertToCommon(x)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void UpdatePatient(int id,PatientsCommon p)
        {
            try
            {
                using (DB_HMOEntities2 db = new DB_HMOEntities2())
                {
                    Patients_tbl patients_ = new Patients_tbl();
                    patients_.ConvertFromCommon(p);
                    Patients_tbl p2 = db.Patients_tbl.First(com => com.ID == id);
                    p2.FirstName = patients_.FirstName;
                    p2.LastName = patients_.LastName;
                    p2.City = patients_.City;
                    p2.Street = patients_.Street;
                    p2.HouseNumber = patients_.HouseNumber;
                    p2.Phone = patients_.Phone;
                    p2.MobilePhone = patients_.MobilePhone;
                    p2.DateOfBirth = patients_.DateOfBirth;
                    db.SaveChanges();
                    List<Patients_tbl> tbs = db.Patients_tbl.ToList();
                    tbs.Select(x => x.ConvertToCommon(x)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddVaccination(Vaccination_tbl v)
        {
            try
            {
                using (DB_HMOEntities2 db = new DB_HMOEntities2())
                {

                    int sum = db.Vaccination_tbl.Where(com => com.PatientId == v.PatientId).Max(com => com.VaccinatioNumber).Value;
                    if (sum < 4)
                    {
                        v.VaccinatioNumber = sum + 1;
                        db.Vaccination_tbl.Add(v);
                        db.SaveChanges();
                        List<Vaccination_tbl> tbs = db.Vaccination_tbl.ToList();
                        tbs.Select(x => x.ConvertToCommon(x)).ToList();
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddStatusCOVID19(StatusCOVID19_tbl s)
        {
            try
            {
                using (DB_HMOEntities2 db = new DB_HMOEntities2())
                {
                    db.StatusCOVID19_tbl.Add(s);
                    db.SaveChanges();
                    List<StatusCOVID19_tbl> tbs = db.StatusCOVID19_tbl.ToList();
                    tbs.Select(x => x.ConvertToCommon(x)).ToList();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
