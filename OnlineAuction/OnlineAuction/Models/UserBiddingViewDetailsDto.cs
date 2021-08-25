using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineAuction.DTO
{
    public class UserBiddingViewDetailsDto
    {
        public UserBiddingDetailsDto userBiddingDetails {get; set;}
        public UsersDto user { get; set; }
    }
}