using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsWebAPI.Domain.Entities
{
    public class Buyer
    {
        public int BuyerId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BuyerQuote> BuyerQuotes { get; set; }
    }
}
