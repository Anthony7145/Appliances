using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances
{
    public class Appliances
    {
        private readonly Microwave mw = new();
        public int Quantity { get; set; }
        
        public long ItemNumber { get; set; }

        public string? Brand { get; set; }
            
        public double Wattage { get; set; }

        public string? Color { get; set; }

        public double Price { get; set; }

        private bool IsAvailable { get; set; }
   
        


        //private void Checkout();

        //private string formatForFile(string format);

        //private string toString(string format) { }
    }
}
    
