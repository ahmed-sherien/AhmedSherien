using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AhmedSherien.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Ahmed Sherien";
            ViewBag.ProfilePic = String.Format("data:image/jpeg;base64,{0}", Convert.ToBase64String(System.IO.File.ReadAllBytes(Server.MapPath(@"~/Content/images/profile_pic.jpg"))));
            return View();
        }
    }
}
