using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingSite
{
    public class User
    {
        public int UserID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User() { } //default constructor

        public User(int userID, string firstname, string lastname, string email, string password)
        {
            UserID = userID;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
        }

        public virtual void CreateUser(int userID, string firstname, string lastname, string email, string password)
        {
            UserID = userID;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
        }


        /*
        public virtual void GetUserDetails()
        {
            Console.WriteLine("Enter FirstName:");
            Console.WriteLine("Enter LastName:");
            Console.WriteLine("Enter Email:");
            Console.WriteLine("Enter Password: ");
        } */

    }
}
