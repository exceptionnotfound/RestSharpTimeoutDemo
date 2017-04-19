using RestSharpTimeoutDemo.MVC.Clients;
using RestSharpTimeoutDemo.MVC.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestSharpTimeoutDemo.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var client = new DateClient();
            var model = new HomeIndexVM();
            model.CurrentDate = client.GetDate();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}