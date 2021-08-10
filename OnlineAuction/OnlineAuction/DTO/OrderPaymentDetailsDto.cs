using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class OrderPaymentDetailsDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
