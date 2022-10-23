using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;
using DAL;
using BLL;
using Common;
using System.Web.Services.Protocols;
using System.Threading.Tasks;

namespace HMOserver.Controllers
{


    //[RoutePrefix("api/HMO")]
    //[AcceptVerbs("GET", "POST")]
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/HMO")]   
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    

    public class HMOController : ApiController
    {
        
        [HttpGet]
        [Route("GetAllPatients")]
        //[EnableCors("AllowOrigin")]
        public IHttpActionResult GetAllPatients()
        {
            try
            {
                List<PatientsCommon> tbs = BllHMO.GetAllPatients();
                List<StatusCOVID19Common> tbs1 = BllHMO.getAllStatusCOVID19();

                return Ok(tbs);
              
            }
            catch (Exception)
            {
                throw;
            }
        }

        [Route("GetAllStatusCOVID19")]
        [HttpGet]
        public IHttpActionResult GetAllStatusCOVID19()
        {
            try
            {
                
                List<StatusCOVID19Common> tbs = BllHMO.getAllStatusCOVID19();

                return Ok(tbs);

            }
            catch (Exception)
            {
                throw;
            }
        }

        [Route("GetAllVaccinations")]
        [HttpGet]
        public IHttpActionResult GetAllVaccinations()
        {
            try
            {

                List<VaccinationCommon> tbs = BllHMO.getAllVaccinations();

                return Ok(tbs);

            }
            catch (Exception)
            {
                throw;
            }
        }

        [Route("GetAllMakers")]
        [HttpGet]
        public IHttpActionResult GetAllMakers()
        {
            try
            {

                List<MakerCommon> tbs = BllHMO.getAllMakers();

                return Ok(tbs);

            }
            catch (Exception)
            {
                throw;
            }
        }

        [Route("GetPatient/{id}")]
        [HttpGet]
        public IHttpActionResult GetPatient(int id)
        {
            try
            {
                PatientsCommon tbs = BllHMO.getPatient(id);
                return Ok(tbs);

            }
            catch (Exception)
            {
                throw;
            }
        }

        [Route("AddNewPatient/{FirstName}/{LastName}/{City}/{Street}/{HouseNumber}/{Phone}/{MobilePhone}/{DateOfBirth}")]
        [HttpPost]
        public void AddNewPatient(string FirstName="",string LastName="", string City="",string Street="",int HouseNumber=0,int Phone=0, int MobilePhone=0,DateTime DateOfBirth=new DateTime())
        {
            try
            {
                PatientsCommon tbs = new PatientsCommon();
                tbs.FirstName = FirstName;
                tbs.LastName = LastName;
                tbs.City = City;
                tbs.Street = Street;
                tbs.HouseNumber = HouseNumber;
                tbs.Phone = Phone;
                tbs.MobilePhone = MobilePhone;
                tbs.DateOfBirth = DateOfBirth;
                BllHMO.AddPatient(tbs);
                Ok(tbs);

            }
            catch (Exception)
            {
                throw;
            }
        }

        [Route("UpdatePatient/{id}/{FirstName}/{LastName}/{City}/{Street}/{HouseNumber}/{Phone}/{MobilePhone}/{DateOfBirth}")]
        [HttpPost]
        public void UpdatePatient(int id, string FirstName = "", string LastName = "", string City = "", string Street = "", int HouseNumber = 0, int Phone = 0, int MobilePhone = 0,DateTime DateOfBirth = new DateTime())
        {
            try
            {
                PatientsCommon tbs = new PatientsCommon();
                
                tbs.FirstName = FirstName;
                tbs.LastName = LastName;
                tbs.City = City;
                tbs.Street = Street;
                tbs.HouseNumber = HouseNumber;
                tbs.Phone = Phone;
                tbs.MobilePhone = MobilePhone;
                tbs.DateOfBirth = DateOfBirth;
                BllHMO.UpdatePatient(id, tbs);
                Ok(tbs);

            }
            catch (Exception)
            {
                throw;
            }
        }
        //[HttpDelete]
        [HttpPost, ActionName("Delete")]
        [Route("DeletePatients/{id_}")]
        [System.Web.Mvc.ValidateAntiForgeryToken]
        
        public void DeletePatients(int id_)
        {
            try
            {

                PatientsCommon tbs = BllHMO.getPatient(id_);               
                BllHMO.DeletePatient(tbs);
                //GetAllPatients();
                //Ok(tbs);
                Ok(tbs);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}