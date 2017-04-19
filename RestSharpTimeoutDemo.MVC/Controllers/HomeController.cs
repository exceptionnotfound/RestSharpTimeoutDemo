using RestSharpTimeoutDemo.MVC.Clients;
using RestSharpTimeoutDemo.MVC.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RestSharpTimeoutDemo.MVC.Controllers
{
    [RoutePrefix("home")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("index")]
        public ActionResult Index()
        {
            var client = new DateClient();
            var model = new HomeIndexVM();
            model.CurrentDate = client.GetDate();
            return View(model);
        }

        [HttpGet]
        [Route("async")]
        public async Task<ActionResult> Async()
        {
            var client = new DateClient();
            var model = new HomeIndexVM();
            model.CurrentDate = await client.GetDateAsync();
            return View("Index", model);
        }
    }
}