using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances
{
    internal class Dishwasher : Appliances
    {
        public int quantity { get; set; }

        public long itemNumber { get; set; }

        public string? brand { get; set; }
        public double wattage { get; set; }

        public string? color { get; set; }

        public double price { get; set; }
    }

}
