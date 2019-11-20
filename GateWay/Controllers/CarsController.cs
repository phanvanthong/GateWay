using Entities;
using GateWay.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GateWay.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CarsController : ApiController
    {
        CarBL carBL = new CarBL();
        [Route("cars")]
        [HttpGet]
        public HttpResponseMessage GetAllCar()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { code = 0, message = "Success", data = carBL.GetAllCar() });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { code = 1, message = "Fail", data = e });
            }

        }

        
    }
}
