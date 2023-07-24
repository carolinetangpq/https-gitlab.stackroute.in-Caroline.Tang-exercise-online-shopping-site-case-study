using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingSite
{
    public class Item : Category
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public virtual void GetItemDetails(string categoryName, string name, string color, double price)
        {
            CategoryName = categoryName;
            Name = name;
            Color = color;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} \n Details: {1}\n Price: {2}", Name, Color, Price);
        }
    }
}
