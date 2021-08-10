using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class FeesDto
    {
        public int Id { get; set; }
        public string Feetype { get; set; }
        public decimal FeeValue { get; set; }
    }
}
