using OnlineAuction.Data;
using OnlineAuction.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineAuction.Controllers
{
    public class UserController : ApiController
    {
        UserData UserData = new UserData();

        [HttpGet]
        public HttpResponseMessage GetUsersList()
        {
            try
            {
                List<UsersDto> users = UserData.GetUsersList();

                return Request.CreateResponse(HttpStatusCode.OK, users);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError,ex.Message);
            }

        }

        [HttpGet]
        public HttpResponseMessage GetUser([FromBody] int id)
        {
            try
            {
                UsersDto user = UserData.GetUser(id);

                return Request.CreateResponse(HttpStatusCode.OK, user);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpPost]
        public HttpResponseMessage SaveUser([FromBody] UsersDto users)
        {
            try
            {
                if (UserData.SaveUser(users))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "User Save Successfully");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "User not save ");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}