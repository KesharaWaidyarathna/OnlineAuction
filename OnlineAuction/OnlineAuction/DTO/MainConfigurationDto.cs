using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class MainConfigurationDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int ContactNumber { get; set; }
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal CommissionRate { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}
