using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances
{
    internal class Vacuum : Appliances
    {
        public int quantity;

        public long itemNumber;

        public string? brand;

        public string? color { get; set; }

        public double price { get; set; }
    }
}
