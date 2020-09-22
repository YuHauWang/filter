using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApplication9.Security
{
    public class TokenFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            string m = "";
            m = "123";
            throw new System.Exception("Token Expired");
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            string m = "";
            m = "123";
        }
    }
}