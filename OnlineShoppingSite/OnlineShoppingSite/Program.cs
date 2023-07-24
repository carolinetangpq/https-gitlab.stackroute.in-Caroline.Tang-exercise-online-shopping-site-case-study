using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingSite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User newCust = new Customer();
            newCust.CreateUser(001, "Mary", "Jane", "maryjane001@gmail.com", "maryjane123");

            User newSeller = new Seller();
            newSeller.CreateUser(001, "Bobby", "Lee", "bobbylee001@gmail.com", "bobbylee123");

            Category newCategory = new Category("Electronics");

            Item newItem = new Laptop();
            newItem.GetItemDetails(newCategory.CategoryName, "Dell XPS-2000", "Black", 2000.20);
        }
    }
}
