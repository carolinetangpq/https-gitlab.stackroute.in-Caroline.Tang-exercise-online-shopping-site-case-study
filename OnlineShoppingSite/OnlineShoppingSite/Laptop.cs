using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingSite
{
    public class Laptop : Item
    {
        string Specifications { get; set; }
        string Weight { get; set; }

        public override void GetItemDetails(string categoryName, string name, string color, double price)
        {
            base.GetItemDetails(categoryName, name, color, price);
            Console.WriteLine("Input Specifications");
            Specifications = Console.ReadLine();
            Console.WriteLine("Input Weight");
            Weight = Console.ReadLine();

        }

        public override string ToString()
        {
            return string.Format("Category: {0} Name: {1} \n Details: {2}\n {3} \n {4}\n Price: {5}", CategoryName, Name, Color, Specifications, Weight, Price);
        }
    }
}
