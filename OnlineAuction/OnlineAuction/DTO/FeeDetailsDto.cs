using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class FeeDetailsDto
    {
        public int Id { get; set; }
        public int FeeId { get; set; }
        public int UserId { get; set; }
        public decimal Fee { get; set; }
        public bool IsPaid { get; set; }

    }
}
