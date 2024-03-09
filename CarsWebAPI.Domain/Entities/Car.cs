using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsWebAPI.Domain.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public int Year { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Submodel { get; set; }
        public string ZipCode { get; set; }
    }
}
