using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_WebApi.BusinessLogic;

namespace Test_WebApi.UnitTests
{
    [TestClass]
    public class UnitTest_oilPrice
    {
        [TestMethod]
        public void OilPriceTrend()
        {
            DateTime startDateISO8601 = DateTimeOffset.Parse("2020-01-01T00:00").DateTime; 

            DateTime endDateISO8601 = DateTimeOffset.Parse("2020-01-05T00:00").DateTime;
        
            OilPriceManager oilPriceManager = new OilPriceManager();

            var l = oilPriceManager.GetOilPriceTrend(startDateISO8601, endDateISO8601);
        }
    }
}
