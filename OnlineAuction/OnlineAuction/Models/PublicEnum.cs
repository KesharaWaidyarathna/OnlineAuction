using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.DTO
{
    public class PublicEnum
    {
        public enum UserType
        {
            Admin=1,
            Seller=2,
            Customer=3
        }

        public enum FeeType
        {
            Registration=1,
            AnualFee=2
        }
    }
}
