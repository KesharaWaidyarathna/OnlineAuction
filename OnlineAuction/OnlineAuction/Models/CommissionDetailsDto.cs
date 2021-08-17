using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class CommissionDetailsDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public decimal CommissionRate { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal CommissionValue { get; set; }
    }
}
