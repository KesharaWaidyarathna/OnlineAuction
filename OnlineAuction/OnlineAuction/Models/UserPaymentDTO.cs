using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineAuction.DTO
{
    public class UserPaymentDTO
    {
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public decimal DepositAmount { get; set; }
    }
}