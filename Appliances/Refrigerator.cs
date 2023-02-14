using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances
{
    public class Refrigerator : Appliances
    {
        public long itemNumber;

        public int quantity;

        public string? brand;

        public double wattage { get; set; }

        public string? color { get; set; }

        public double price { get; set; }

        public int NumberofDoors;

        public int Height;

        public int Width;

        private string type { get; set; }

        private double capacity;

        public Refrigerator(int itemNumber, string brand, string type, double capacity)
        {
            ItemNumber = itemNumber;
            Brand = brand;
            this.type = type;
            this.capacity = capacity;
        }

    }
}
