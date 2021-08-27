using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineAuction.DTO
{
    public class ReadyToDispatchItemDto
    {
        public UsersDto User { get; set; }
        public ItemDto Item { get; set; }
        public ItemBiddingDetailsDto ItemBidding { get; set; }
    }
}