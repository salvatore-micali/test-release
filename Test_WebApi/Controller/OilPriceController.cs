using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Test_WebApi.Controller
{
    public class OilPriceController : ApiController
    {
        [HttpGet]
        [Route("api/OilPrice/GetOilPriceTrend")] 
        public string GetOilPriceTrend()
        {
            return "Hello World";
        }
    }
}
