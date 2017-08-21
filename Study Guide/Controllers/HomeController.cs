using System.Web.Mvc;
using Study_Guide.Classes;
using Study_Guide.Models;

namespace Study_Guide.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var teaBoy = new MakeTheTea();
            return View(teaBoy.MakeTheTeaList());
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