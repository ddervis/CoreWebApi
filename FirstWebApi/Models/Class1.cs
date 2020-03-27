using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Models
{
    public class Data
    {
        public bool IsSuccess { get; set; }
        public bool EsbError { get; set; }
        public object Message { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
    }

    public class Header
    {
        public object message { get; set; }
        public string status { get; set; }
        public int statusCode { get; set; }
        public object detailCode { get; set; }
        public object txId { get; set; }
        public List<object> warnings { get; set; }
    }

    public class RootObject
    {
        public Data data { get; set; }
        public Header header { get; set; }
    }
}
