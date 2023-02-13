using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances
{
    internal class Microwave : Appliances
    {
        public int quantity;

        public long itemNumber;

        public string? brand;

        public double wattage { get; set; }

        public string? color { get; set; }

        public double price { get; set; }
    }
}
//public static void RefInfo(long itemNumber, string brand, int quantity, double wattage, string color, double price);