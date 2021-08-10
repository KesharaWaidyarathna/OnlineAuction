using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class UserBiddingDetailsDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime BidDate { get; set; }
        public int BidCount { get; set; }
        public DateTime InspectionDate { get; set; }
        public decimal BidValue { get; set; }
        public bool IsIncpectionApproved { get; set; }
        public bool IsCancelled { get; set; }
    }
}
