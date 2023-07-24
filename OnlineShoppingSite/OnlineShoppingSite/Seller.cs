using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingSite
{
    class Seller : User
    {
        public Seller() { }

        public override void CreateUser(int userID, string firstname, string lastname, string email, string password)
        {
            base.CreateUser(userID, firstname, lastname, email, password);
        }
    }
}
