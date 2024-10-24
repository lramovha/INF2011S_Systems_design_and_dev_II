using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Project.Business;

namespace Project.Business
{
    public class Customer:Person
    {
        private string customerID;

        public Customer()
        {
        }

        public string CustomerID { get => customerID; set => customerID = value; }
    }
}
