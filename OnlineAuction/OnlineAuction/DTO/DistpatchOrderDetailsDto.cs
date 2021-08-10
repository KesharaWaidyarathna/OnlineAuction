using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class DistpatchOrderDetailsDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Address { get; set; }
        public decimal DeliveryCost { get; set; }
        public DateTime DeilverdDate { get; set; }
        public bool IsDeliverd { get; set; }
    }
}
