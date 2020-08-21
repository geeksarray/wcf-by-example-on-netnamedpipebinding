using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;  

namespace NorthwindServices
{
    [ServiceContract] 
    public interface ICustomer
    {
        [OperationContract]
        string GetCustomerName(int CustomerID);

        [OperationContract]
        int GetCustomerCount();
    }
}
