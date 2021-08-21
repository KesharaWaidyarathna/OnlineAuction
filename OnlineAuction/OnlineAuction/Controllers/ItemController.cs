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
    public class ItemController : ApiController
    {
        ItemData itemData = new ItemData();

        [Route("api/Item/GetItemList")]
        [HttpGet]
        public HttpResponseMessage GetItemList()
        {
            try
            {
                List<ItemDto> items = itemData.GetItemList();
                if(items.Count>0)
                    return Request.CreateResponse(HttpStatusCode.OK, items);

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError,"No items to load");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/Item/GetItem")]
        [HttpGet]
        public HttpResponseMessage GetItem([FromBody] int id)
        {
            try
            {
                ItemDto item = itemData.GetItem(id);
                if(item!=null)
                    return Request.CreateResponse(HttpStatusCode.OK, item);


                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError,"Invalid ItemId");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/Item/SaveItem")]
        [HttpPost]
        public HttpResponseMessage SaveItem([FromBody] ItemDto item,ItemBiddingDetailsDto itemBidding)
        {
            try
            {
                if (itemData.SaveItem(item))
                {
                    if(itemData.SaveItemBiddingDetail(itemBidding))
                        return Request.CreateResponse(HttpStatusCode.OK, "Item Save Successfully");

                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Item details not save ");
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

        [Route("api/Item/GetItemAllBids")]
        [HttpGet]
        public HttpResponseMessage GetItemAllBids([FromBody] int ItemID)
        {
            try
            {
               List<UserBiddingDetailsDto> userBiddingDetails = itemData.GetItemAllBids(ItemID);
               
                if(userBiddingDetails !=null)
                    return Request.CreateResponse(HttpStatusCode.OK, userBiddingDetails);

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError,"Request fail");

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

    }
}