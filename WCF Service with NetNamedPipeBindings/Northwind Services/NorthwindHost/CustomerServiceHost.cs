using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using NorthwindServices;  

namespace NorthwindHost
{
    public class CustomerServiceHost
    {
        static ServiceHost serviceHost = null;
        public CustomerServiceHost()
        {
            
        }

        internal static void Start()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            // Create a ServiceHost for the ProductService type and 
            // provide the base address.
            serviceHost = new ServiceHost(typeof(CustomerService));

            // Open the ServiceHostBase to create listeners and start 
            // listening for messages.
            serviceHost.Open();
        }

        internal static void Stop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
