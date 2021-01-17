using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test_WebApi.BusinessLogic;

namespace Test_WebApi.Controller
{
    public class OilPriceController : ApiController
    {
        [HttpGet]
        [Route("api/OilPrice/GetOilPriceTrend")]
        public HttpResponseMessage GetOilPriceTrend(DateTime startDateISO8601, DateTime endDateISO8601)
        {
            OilPriceManager oilPriceManager = new OilPriceManager();

            var l = oilPriceManager.GetOilPriceTrend(startDateISO8601, endDateISO8601);
            string resultjson = JsonConvert.SerializeObject(
                       new
                       {
                           jsonrpc = "2.0",
                           id = "1",
                           prices = l
                          
                       }
                       );
            return Request.CreateResponse(HttpStatusCode.OK, resultjson);
        }
    }

     
}
