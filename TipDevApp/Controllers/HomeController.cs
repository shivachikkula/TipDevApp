using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
namespace TipDevApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DataTable dt = new StudentRepo().GetStudentData();
            return View(dt);
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