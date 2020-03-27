using SoapWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SoapWebApi.Services
{
    public class SampleService : ISampleService
    {
        public string Test(string s)
        {
            var testString = "Test Method Executed!";
            return testString;
        }

        public Customer TestCustomer(Customer customer)
        {
            return customer;
        }

        public void XmlMethod(XElement xml)
        {
            Console.WriteLine(xml.ToString());
        }

     
    }
}
