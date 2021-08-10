using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class ItemDto
    {
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public string ItemName { get; set; }
        public string CategoryName { get; set; }
        public string ItemDiscription { get; set; }
        public decimal ItemValue { get; set; }
        public decimal InitalBid { get; set; }
        public byte[] Image1 { get; set; }
        public byte[] Image2 { get; set; }
        public byte[] Image3 { get; set; }
        public byte[] Image4 { get; set; }
        public byte[] Image5 { get; set; }
        public byte[] Video { get; set; }
        public string Location { get; set; }
        public decimal SoldPrice { get; set; }
        public DateTime SoldDate { get; set; }
        public bool IsSold { get; set; }

    }
}
