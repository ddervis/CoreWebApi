using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace SoapWebApi.Models
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        string Test(string s);
        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);
        [OperationContract]
        Customer TestCustomer(Customer customer);
    }
}
