using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WebApi.Model
{
    public class OilPriceIn
    {
        public DateTime Date { get; set; }
        public  decimal Price { get; set; }
    }

    public class OilPriceOut
    {
        public DateTime dateISO8601 { get; set; }
        public decimal price { get; set; }
    }
}
