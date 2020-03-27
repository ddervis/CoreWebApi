using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Models
{
    public class GetExchangeRate
    {
        public class CurrencyPrice
        {
            public string CurrencyName { get; set; }
            public double BID { get; set; }
            public double ASK { get; set; }
        }

        public class TranDateClass
        {
            public DateTime TranDate { get; set; }
            public List<CurrencyPrice> CurrencyPrices { get; set; }
        }
    }
}
