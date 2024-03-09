﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsWebAPI.Domain.Entities
{
    public class BuyerQuote
    {
        public int QuoteId { get; set; }
        public int BuyerId { get; set; }
        public int CarId { get; set; }
        public decimal Amount { get; set; }

        public virtual Buyer Buyer { get; set; }
        public virtual Car Car { get; set; }
    }
}
