using Entities;
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
    public class UsersController : ApiController
    {
        //IUserRepository iUser;
        UserBL userBL = new UserBL();
        public HttpResponseMessage GetAllUser()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { code = 0, message = "Success", data = userBL.GetAllUser() });
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { code = 1, message = "Fail", data = e});
            }

        }

        public User GetUserByID(Guid ID)
        {
            return userBL.GetUserByID(ID);
        }

    }
}
 