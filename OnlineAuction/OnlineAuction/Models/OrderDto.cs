using OnlineAuction.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineAuction.Models
{
    public class OrderDto
    {
        public OrderDetailsDto OrderDetailsDto { get; set; }

        public OrderPaymentDetailsDto OrderPaymentDetailsDto { get; set; }
    }
}