using System;
using System.Collections.Generic;
using System.Linq;

namespace Appliances
{
    internal class Program
    {
        private static readonly List<Appliances> appliancesList = new List<Appliances>();

        public static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Welcome to Modern Appliances!");
            Console.WriteLine("How may we assist you?");
            Console.WriteLine("1 - Check out appliance");
            Console.WriteLine("2 - Find appliances by brand");
            Console.WriteLine("3 - Display appliances by type");
            Console.WriteLine("4 - Produce random appliance list");
            Console.WriteLine("5 - Save & exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the item number of the appliance you would like to check out:");
                    int itemNumber = Convert.ToInt32(Console.ReadLine());
                    bool found = false;
                    foreach (Appliances appliance in appliancesList)
                    {
                        if (appliance.ItemNumber == itemNumber)
                        {
                            Console.WriteLine(appliance);
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("No appliances found with that item number.");
                    }
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Enter the brand of the appliance you are looking for:");

                    string brand = Console.ReadLine();

                    List<Appliances> matchingBrands = new List<Appliances>();
                    foreach (Appliances appliance in appliancesList)
                    {
                        if (appliance.Brand.ToLower().Contains(brand.ToLower()))
                        {
                            matchingBrands.Add(appliance);
                        }
                    }
                    if (matchingBrands.Count == 0)
                    {
                        Console.WriteLine(" No matching brands found.");
                    }

                    else
                    {
                        foreach (Appliances appliances in matchingBrands)
                        {
                            Console.WriteLine(appliances);
                        }
                    }

                    if (!string.IsNullOrEmpty(brand))
                    {
                        foreach (Appliances appliance in appliancesList)
                        {
                            if (appliance.Brand.ToLower().Contains(brand.ToLower()))
                            {
                                matchingBrands.Add(appliance);
                            }
                        }
                    }
                    if (matchingBrands.Count == 0)
                    {
                        Console.WriteLine("No matching brands found.");
                    }
                    else
                    {
                        foreach (Appliances appliances in matchingBrands)
                        {
                            Console.WriteLine(appliances);
                        }
                    }
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Enter the type of appliance you are looking for (refrigerator, vacuum,microwave, or dishwasher):");
                    string type = Console.ReadLine();
                    if (type == "refrigerator")
                    {
                        Console.WriteLine("Refrigerators:");
                        foreach (Refrigerator refrigerator in appliancesList.OfType<Refrigerator>())
                        {
                            Console.WriteLine(refrigerator);
                        }
                    }
                    else if (type == "vacuum")
                    {
                        Console.WriteLine("Vacuums:");
                        foreach (Vacuum vacuum in appliancesList.OfType<Vacuum>())
                        {
                            Console.WriteLine(vacuum);
                        }
                    }
                    else if (type == "microwave")
                    {
                        Console.WriteLine("Microwaves:");
                        foreach (Microwave microwave in appliancesList.OfType<Microwave>())
                        {
                            Console.WriteLine(microwave);
                        }
                    }
                    else if (type == "dishwasher")
                    {
                        Console.WriteLine("Dishwashers:");
                        foreach (Dishwasher dishwasher in appliancesList.OfType<Dishwasher>())
                        {
                            Console.WriteLine(dishwasher);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid appliance type.");
                    }
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Random Appliance List:");
                    Random random = new();
                    for (int i = 0; i < 5; i++)
                    {
                        int index = random.Next(appliancesList.Count);
                        Console.WriteLine(appliancesList[index]);
                    }
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;

            }
            string path = @"C:\Users\antho\Videos\Appliances\appliances.txt";
            

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] applianceDetails = line.Split(',');
                        int itemNumber = int.Parse(applianceDetails[0]);
                        string brand = applianceDetails[1];
                        string type = applianceDetails[2];
                        if (type == "Refrigerator")
                        {
                            double capacity = double.Parse(applianceDetails[3]);
                            appliancesList.Add(new Refrigerator(itemNumber, brand, type, capacity));
                        }
                        else if (type == "Vacuum")
                        {
                            string bagType = applianceDetails[3];
                            appliancesList.Add(new Vacuum(itemNumber, brand, type, bagType));
                        }
                        else if (type == "Microwave")
                        {
                            int wattage = int.Parse(applianceDetails[3]);
                            appliancesList.Add(new Microwave(itemNumber, brand, type, wattage));
                        }
                        else if (type == "Dishwasher")
                        {
                            int rackCount = int.Parse(applianceDetails[3]);
                            appliancesList.Add(new Dishwasher(itemNumber, brand, type, rackCount));
                        }
                    }
                }
            }


            while (true) ;
        }
    }
}

