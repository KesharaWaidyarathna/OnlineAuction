using OnlineAuction.Data;
using OnlineAuction.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineAuction.Controllers
{

    public class ItemController : Controller
    {
        ItemData ItemData = new ItemData();
        // GET: Item
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string ItemSave(HttpRequest request)
        {
            string stats = "";

            return stats;
        }

        [HttpPost]
        public string ItemUpdate(HttpRequest request)
        {
            string stats = "";

            return stats;
        }

        [HttpGet]
        public ItemDto GetItem(int id)
        {
            //return UserData.GetUser(id);
        }

    }
}