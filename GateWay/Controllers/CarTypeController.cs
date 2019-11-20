using GateWay.BL;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GateWay.Controllers
{
    public class CarTypeController : ApiController
    {
        //ICartypeRepository iCarType;
        CarTypeBL carTypeBL = new CarTypeBL(); 
        public HttpResponseMessage GetAllCar()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { code = 0, message = "Success", data = carTypeBL.GetAllCarType() });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { code = 1, message = "Fail", data = e });
            }

        }

    }
}
