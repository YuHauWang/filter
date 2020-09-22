using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using WebApplication9.Security;

namespace WebApplication9
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Filters.Add(new TokenFilter());
            GlobalConfiguration.Configuration.Filters.Add(new WebApiException());
        }
    }
}
