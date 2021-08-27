using OnlineAuction.Data;
using OnlineAuction.DTO;
using OnlineAuction.Models;
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
                ItemDetailListDTO itemDetailList = new ItemDetailListDTO();
                List<ItemDto> items = itemData.GetItemList();
                List<ItemBiddingDetailsDto> itemBiddings = itemData.GetItemBiddingDetalList();
                if (items.Count > 0 && itemBiddings.Count > 0)
                {
                    itemDetailList.Item = items;
                    itemDetailList.itemBidding = itemBiddings;
                    return Request.CreateResponse(HttpStatusCode.OK, itemDetailList);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No items to load");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/Item/GetItemListByUserId")]
        [HttpPost]
        public HttpResponseMessage GetItemListByUserId([FromBody] ItemDto itemDto)
        {
            try
            {
                ItemDetailListDTO itemDetailList = new ItemDetailListDTO();
                List<ItemDto> items = itemData.GetItemListByUserId(itemDto);
                List<ItemBiddingDetailsDto> itemBiddings = itemData.GetItemBiddingDetalListByUser(itemDto);
                if (items.Count > 0 && itemBiddings.Count > 0)
                {
                    itemDetailList.Item = items;
                    itemDetailList.itemBidding = itemBiddings;
                    return Request.CreateResponse(HttpStatusCode.OK, itemDetailList);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No items to load");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/Item/GetItemListByUserBidded")]
        [HttpPost]
        public HttpResponseMessage GetItemListByUserBidded([FromBody] UserBiddingDetailsDto userBiddingDetailsDto)
        {
            try
            {
                ItemDetailListDTO itemDetailList = new ItemDetailListDTO();
                List<ItemDto> items = itemData.GetItemListByUserBidded(userBiddingDetailsDto);
                List<ItemBiddingDetailsDto> itemBiddings = itemData.GetItemBiddingListByUserBidded(userBiddingDetailsDto);
                if (items.Count > 0 && itemBiddings.Count > 0)
                {
                    itemDetailList.Item = items;
                    itemDetailList.itemBidding = itemBiddings;
                    return Request.CreateResponse(HttpStatusCode.OK, itemDetailList);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No items to load");
                }

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
                if (item != null)
                    return Request.CreateResponse(HttpStatusCode.OK, item);


                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Invalid ItemId");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("api/Item/SaveItem")]
        [HttpPost]
        public HttpResponseMessage SaveItem([FromBody] ItemDetailDTO itemDetail)
        {
            try
            {
                if (itemData.SaveItem(itemDetail.Item))
                {
                    ItemDto itemId = itemData.GetLastItemId();
                    itemDetail.itemBidding.ItemId = itemId.ItemId;
                    if (itemData.SaveItemBiddingDetail(itemDetail.itemBidding))
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

        [Route("api/Item/GetHighestBid")]
        [HttpPost]
        public HttpResponseMessage GetHighestBid([FromBody] ItemDto itemDetail)
        {
            try
            {
                ItemBiddingDetailsDto itemBiddingDetails = itemData.GetHighestBid(itemDetail.ItemId);

                return Request.CreateResponse(HttpStatusCode.OK, itemBiddingDetails.HighestBid);

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

                if (userBiddingDetails != null)
                    return Request.CreateResponse(HttpStatusCode.OK, userBiddingDetails);

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Request fail");

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}