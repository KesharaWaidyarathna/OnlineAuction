using OnlineAuction.Data;
using OnlineAuction.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OnlineAuction.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        UserData UserData = new UserData();

        [Route("api/User/GetUsersList")]
        [HttpGet]
        public HttpResponseMessage GetUsersList()
        {
            try
            {
                List<UsersDto> users = UserData.GetUsersList();

                return Request.CreateResponse(HttpStatusCode.OK, users);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/User/GetUsersList/Buyers/all")]
        [HttpGet]
        public HttpResponseMessage GetBuyersList()
        {
            try
            {
                List<UsersDto> users = UserData.GetBuyersList();

                return Request.CreateResponse(HttpStatusCode.OK, users);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/User/GetUsersList/Sellers/all")]
        [HttpGet]
        public HttpResponseMessage GetSellersList()
        {
            try
            {
                List<UsersDto> users = UserData.GetSellersList();

                return Request.CreateResponse(HttpStatusCode.OK, users);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/User/GetUsersList/Buyers/Pending")]
        [HttpGet]
        public HttpResponseMessage GetBuyersPendingList()
        {
            try
            {
                List<UsersDto> users = UserData.GetBuyersPendingList();

                return Request.CreateResponse(HttpStatusCode.OK, users);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/User/GetUsersList/Sellers/Pending")]
        [HttpGet]
        public HttpResponseMessage GetSellersPendingList()
        {
            try
            {
                List<UsersDto> users = UserData.GetSellersPendingList();

                return Request.CreateResponse(HttpStatusCode.OK, users);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/User/Approve")]
        [HttpPost]
        public HttpResponseMessage ApproveUser(UsersDto user)
        {
            try
            {
                if (UserData.ApproveUser(user))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Buyer approve Successfully");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Buyer approve failed");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [Route("api/User/Reject")]
        [HttpPost]
        public HttpResponseMessage RejectUser(UsersDto user)
        {
            try
            {
                if (UserData.RejectUser(user))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Buyer reject Successfully");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Buyer reject failed");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


        [Route("api/User/GetUser")]
        [HttpGet]
        public HttpResponseMessage GetUser([FromBody] UsersDto users)
        {
            try
            {
                UsersDto user = UserData.GetUser(users.Id);
                if (user != null)
                    return Request.CreateResponse(HttpStatusCode.OK, user);


                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "User Id Invalid");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/User/SaveUser")]
        [HttpPost]
        public HttpResponseMessage SaveUser([FromBody] UsersDto users)
        {
            try
            {
                UsersDto blacklistUser = UserData.CheckBlacklist(users.Email);
                string ValidEmail = UserData.EmailValidation(users.Email);

                if (blacklistUser.Email == null)
                {
                    if (String.IsNullOrEmpty(ValidEmail))
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
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "User Email already regisrterd ");
                    }
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "User Blacklisted ");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Route("api/User/SaveUserBid")]
        [HttpPost]
        public HttpResponseMessage SaveUserBid([FromBody] UserBiddingDetailsDto userBid)
        {
            try
            {
                if (UserData.SaveUserBid(userBid))
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

        [Route("api/User/SwitchToSeller")]
        [HttpPost]
        public HttpResponseMessage SwitchToSeller([FromBody] UsersDto user)
        {
            try
            {
                if (UserData.SwitchToSeller(user.Id))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "User Switch to Seller successfully");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "User Switch Fail");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [Route("api/User/ConfirmRegistrationPayment")]
        [HttpPost]
        public HttpResponseMessage ConfirmRegistrationPayment([FromBody] UsersDto user)
        {
            try
            {
                if (UserData.ConfirmRegistrationPayment(user.Id))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "User Registration payment confirmd successfully");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "User Registration payment confirmd");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Route("api/User/Login")]
        [HttpPost]
        public HttpResponseMessage Login([FromBody] UsersDto user)
        {
            try
            {
                UsersDto blacklistUser = UserData.CheckBlacklist(user.Email);
                UsersDto accountApproval = UserData.CheckAccountApproval(user.Email);
                UsersDto settleRegistationFee = UserData.CheckSettleRegistartionFee(user.Email);
                if (blacklistUser.Email == null)
                {
                    if (accountApproval.Email != null)
                    {

                        UsersDto Authuser = UserData.UserLogin(user);
                        if (Authuser.Email == null)
                        {
                            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Username Password is wrong");
                        }

                        if (settleRegistationFee.Email != null)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, Authuser);
                        }
                        else
                        {
                            return Request.CreateResponse(HttpStatusCode.Accepted, Authuser);
                        }
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.ServiceUnavailable, "Account is not approved");
                    }
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "User Blacklist");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/User/SaveBlackListUser")]
        [HttpPost]
        public HttpResponseMessage SaveBlackListUser([FromBody] BlacklistUsersDto blacklistUser)
        {
            try
            {
                if (UserData.SaveBlackListUser(blacklistUser))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "User Blacklist Successfully");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "User not Blacklist ");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}