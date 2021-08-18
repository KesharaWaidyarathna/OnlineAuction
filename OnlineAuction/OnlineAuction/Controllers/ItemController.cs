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
    public class ItemController : ApiController
    {
        ItemData itemData = new ItemData();

        [HttpGet]
        public HttpResponseMessage GetItemList()
        {
            try
            {
                List<ItemDto> items = itemData.GetItemList();

                return Request.CreateResponse(HttpStatusCode.OK, items);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpGet]
        public HttpResponseMessage GetItem([FromBody] int id)
        {
            try
            {
                ItemDto item = itemData.GetItem(id);

                return Request.CreateResponse(HttpStatusCode.OK, item);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpPost]
        public HttpResponseMessage SaveItem([FromBody] ItemDto item)
        {
            try
            {
                if (itemData.SaveItem(item))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Item Save Successfully");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Item not save ");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}