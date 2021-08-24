using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class ItemBiddingDetailsDto
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public DateTime BidStartDate { get; set; }
        public DateTime BidEndDate { get; set; }
        public DateTime InspectionStartDate { get; set; }
        public DateTime InspectionEndDate { get; set; }
        public decimal StartingBid { get; set; }
        public decimal HighestBid { get; set; }
    }
}
