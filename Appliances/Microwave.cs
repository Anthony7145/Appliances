using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances
{
    internal class Microwave : Appliances
    {
        public long itemNumber;

        public int quantity; 
        
        public string? brand;

        public double wattage { get; set; }

        public string? color { get; set; }

        public double price { get; set; }

        public int Capacity;

        public int RoomType;

        private string? type;

        public Microwave(int itemNumber, string brand, string type, int wattage)
        {
            ItemNumber = itemNumber;
            Brand = brand;
            this.type = type;
            Wattage = wattage;
        }

        public Microwave()
        {
        }
    }
}
//public static void RefInfo(long itemNumber, string brand, int quantity, double wattage, string color, double price);