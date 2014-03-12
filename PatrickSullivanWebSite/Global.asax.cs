using PatrickSullivanWebSite.AppStart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;

namespace PatrickSullivanWebSite
{
    /*
    public class StoreDB 
    {
        public BiggyList<Product> Products;
        public BiggyList<Customer> Customer;
        
        public StoreDB()
        {
            Products = new BiggyList<Product>(dbPath: HttpRuntime.AppDomainAppPath);
            Customers = new BiggyList<Customerss>(dbPath: HttpRuntime.AppDomainAppPath);
        }
    }
    
    */
    
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

    }
}
