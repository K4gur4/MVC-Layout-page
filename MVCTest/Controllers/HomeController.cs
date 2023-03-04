using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTest.Areas.Admin.Models;

namespace MVCTest.Controllers
{
    public class HomeController : Controller
    {
        ContentEtities database = new ContentEtities();
        // GET: Home
        public ActionResult Index()
        {
        var content = database.Contents.ToList();
            return View(content);
        }

        public ActionResult AdminView()
        {
            
            return Redirect(Url.Action("", "Data", new { area = "Admin" }));
        }
    }
}