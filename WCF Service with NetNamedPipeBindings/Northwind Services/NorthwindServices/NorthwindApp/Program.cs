using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NorthwindApp.CustomerServiceRef;  

namespace NorthwindApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int customerID = 2;
            CustomerClient client = new CustomerClient();
            string companyName = client.GetCustomerName(2);
            Console.WriteLine(string.Format("Company name for Customer ID {0} is {1}", customerID,  companyName));
            Console.WriteLine(string.Format("Total number of customers are : {0} ", client.GetCustomerCount()));
            Console.Read();
        }
    }
}
