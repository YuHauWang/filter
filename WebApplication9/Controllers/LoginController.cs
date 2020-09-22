using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication9.Security;

namespace WebApplication9.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage data()
        {
            var req = Request;
            var b = Request.Content.ReadAsStringAsync().Result;
            var h = Request.Headers;
            string xaa = h.GetValues("x-aang").FirstOrDefault();
            HttpResponseMessage hrm = new HttpResponseMessage();
            hrm.Content = new StringContent("{response:'hello world'}");
            hrm.StatusCode = HttpStatusCode.OK;
            return hrm;
        }
    }
}
