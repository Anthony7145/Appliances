using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances
{
    public class Refrigerator : Appliances
    {


        public int quantity;

        public long itemNumber;

        public string? brand;

        public double wattage { get; set; }

        public string? color { get; set; }

        public double price { get; set; }
    }
}
