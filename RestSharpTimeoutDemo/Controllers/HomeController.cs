using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;

namespace RestSharpTimeoutDemo.Controllers
{
    [RoutePrefix("home")]
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("date")]
        public IHttpActionResult GetDate()
        {
            var rand = new Random();
            Thread.Sleep(rand.Next(1, 100));
            return Ok(DateTime.Now);
        }
    }
}
