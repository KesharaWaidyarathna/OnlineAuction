using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class UserDetailsDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CardNumber { get; set; }
        public int Cvv { get; set; }
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
    }
}
