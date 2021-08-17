using OnlineAuction.Data;
using OnlineAuction.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineAuction.Controllers
{
    public class UserController : Controller
    {
        UserData UserData = new UserData();
        // GET: User
        [HttpGet]
        public List<UsersDto> Index()
        {


            return UserData.getUsersList();
        }

        [HttpPost]
        public string UserSave(HttpRequest request)
        {
            string stats = "";

            return stats;
        }

        [HttpPost]
        public string UserUpdate(HttpRequest request)
        {
            string stats = "";

            return stats;
        }

    }
}