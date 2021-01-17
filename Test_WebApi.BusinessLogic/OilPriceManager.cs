using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_WebApi.Model;

namespace Test_WebApi.BusinessLogic
{
    public class OilPriceManager
    {
        public List<OilPriceOut> GetOilPriceTrend(DateTime from, DateTime to)
        {
            List<OilPriceOut> resList = new List<OilPriceOut>();
            var appSettings = ConfigurationManager.AppSettings;
            string PriceSourceLink = appSettings["PriceSourceLink"] ?? "";

            if (!string.IsNullOrEmpty(PriceSourceLink))
            {
                var client = new RestClient(PriceSourceLink);
                var request = new RestRequest(Method.GET);
                var queryResult = client.Execute<List<OilPriceIn>>(request).Data;



                var tmpList = queryResult.Where(i => i.Date > from && i.Date < to).ToList();

                foreach (OilPriceIn i in tmpList) {
                    resList.Add(new OilPriceOut { dateISO8601 = i.Date, price = i.Price });
                }

            }
                       
            return resList;

        }
    }
}
