using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class OrderDetailsDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public decimal Price { get; set; }
        public DateTime SoldDate { get; set; }
        public DateTime DispatchDate { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal DeliveryCharge { get; set; }
        public string City { get; set; }
        public string PickupAddress { get; set; }
        public bool IsDispatch { get; set; }
        public bool IsFullPaid { get; set; }
    }
}
