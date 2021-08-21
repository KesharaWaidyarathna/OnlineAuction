using OnlineAuction.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineAuction.Models
{
    public class ItemDetailListDTO
    {
        public List<ItemDto> Item { get; set; }
        public List<ItemBiddingDetailsDto> itemBidding { get; set; }
    }
}