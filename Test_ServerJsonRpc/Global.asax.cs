using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Test_ServerJsonRpc
{
    public class Global : System.Web.HttpApplication
    {
        static OilPriceService service = new OilPriceService();
        
        protected void Application_Start(object sender, EventArgs e)
        {
            var a = 1;
        }
    }
}