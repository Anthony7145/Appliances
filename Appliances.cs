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
        Microwave mw = new Microwave();
        public int quantity { get; set; }
        
        public long itemNumber { get; set; }

        public string? brand { get; set; }
            
        public double wattage { get; set; }

        public string? color { get; set; }

        public double price { get; set; }

        private bool isAvailable { get; set; }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\videos\OneDrive\Desktop\appliances.txt";
//will need to change path
            string contents = File.ReadAllText(filePath);

            Console.WriteLine(contents);
          //  static void RefInfo(long itemNumber, string brand, int quantity, double wattage, string color, double price);
            
        }


        //private void Checkout();

        //private string formatForFile(string format);

        //private string toString(string format) { }
    }
}
    
