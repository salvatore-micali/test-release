using AustinHarris.JsonRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_ServerJsonRpc
{
    public class OilPriceService : JsonRpcService {

        [JsonRpcMethod]
        private string helloWorld(string message)
        {
            return "Hello World " + message;
        }

    }
}