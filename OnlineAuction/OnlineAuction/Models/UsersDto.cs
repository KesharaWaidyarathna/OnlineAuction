using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class UsersDto
    {
        public int Id { get; set; }
        public int UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime DOB { get; set; }
        public int ContactNumber { get; set; }
        public decimal DepositAmount { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IsApproved { get; set; }

    }
}
