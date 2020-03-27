using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SoapWebApi.Models
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
