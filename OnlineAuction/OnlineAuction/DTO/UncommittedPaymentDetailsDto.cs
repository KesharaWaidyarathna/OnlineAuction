using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class UncommittedPaymentDetailsDto
    {
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime UncommittedtDate { get; set; }
        public bool IsUncommitted { get; set; }
    }
}
