using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances
{
    internal class Vacuum : Appliances
    {
        public new long ItemNumber { get; set; }

        public new string Brand { get; set; }
        
        public new int Quantity { get; set; }

        public new double Wattage { get; set; }

        public new string Color { get; set; } = string.Empty;

        public new double Price { get; set; } = 0.0;

        public int Grade { get; set; } = 0;

        public int BatteryVoltage { get; set; } = 0;

        public readonly string Type;

        public readonly string BagType;

        public Vacuum(long itemNumber, string brand, string type, string bagType)
        {
            ItemNumber = itemNumber;
            Brand = brand;
            Type = type;
            BagType = bagType;
        }
    }

}
