using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances
{
    internal class Dishwasher : Appliances
    {
        string? type;
        private int rackCount;
        public long itemNumber { get; set; }
        public string? brand { get; set; }

        public int quantity { get; set; }
        public double wattage { get; set; }

        public string? color { get; set; }

        public double price { get; set; }

        public Dishwasher(int itemNumber, string brand, string type, int rackCount)
        {
            ItemNumber = itemNumber;
            Brand = brand;
            this.type = type;
            this.rackCount = rackCount;
        }
    }

}
