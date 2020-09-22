using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace WebApplication9.Security
{
    public class WebApiException : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            string msg = "Exception captured by WebApiExceptionFilter: " +
                        context.Exception.GetBaseException().Message;
            var resp = context.Request.CreateErrorResponse(HttpStatusCode.BadRequest, msg);
            //context.Response = context.Request.CreateResponse(HttpStatusCode.InternalServerError,
            //    new { f = "1" });
            HttpResponseMessage hrm = new HttpResponseMessage();
            hrm.Content = new StringContent("{response:'hello world'}");
            hrm.StatusCode = HttpStatusCode.InternalServerError;
            context.Response = hrm;
        }
    }
}