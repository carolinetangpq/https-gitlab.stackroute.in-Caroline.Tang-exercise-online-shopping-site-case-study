using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingSite
{
    public class Customer : User
    {
        //add address
        public string Address { get; set; }
        //create empty cart
        public List<Item> itemsInCart = new List<Item>();

        public Customer() { }

        public Customer(string address, List<Item> itemsInCart)
        {
            Address = address;
            this.itemsInCart = itemsInCart;
        }

        public override void CreateUser(int userID, string firstname, string lastname, string email, string password)
        {
            base.CreateUser(userID, firstname, lastname, email, password);
            Console.WriteLine("Input your Address");
            Address = Console.ReadLine();
        }

        /*
        public override void GetUserDetails()
        {
            base.GetUserDetails(); 
            Console.WriteLine("Enter Address: ");
            Address = Console.ReadLine(); 

        }*/

        public void AddItems()
        {
            Item item1 = new Item(); //new item instance
            Console.WriteLine("Add {0} into cart? ", item1);
            itemsInCart.Add(item1);

        }

        public void ViewCart()
        {
            foreach (Item item in itemsInCart)
            {
                {
                    Console.WriteLine("Items in cart: {0}", item);
                }
            }
        }

        public void MakePayment() { }
    }
}
