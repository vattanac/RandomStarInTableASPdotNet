using RandomStarTabel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace RandomStarTabel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateTable(string row ,string min,string max)
        {
            int r = int.Parse(row);
            int mi = int.Parse(min);
            int ma = int.Parse(max);
            Table tb = new Table(r,mi,ma);
            return View(tb);
        }
    }
}