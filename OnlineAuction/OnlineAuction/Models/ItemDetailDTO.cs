using OnlineAuction.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineAuction.Models
{
    public class ItemDetailDTO
    {
        public ItemDto Item { get; set; }
        public ItemBiddingDetailsDto itemBidding { get; set; }
    }
}