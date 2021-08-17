using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class ReturnOrderDetailsDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int DispatchOrderDetailId { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Comments { get; set; }
    }
}
