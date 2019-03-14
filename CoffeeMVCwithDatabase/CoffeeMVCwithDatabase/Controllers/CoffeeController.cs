using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeMVCwithDatabase.Controllers
{
    public class CoffeeController : Controller
    {
        // GET: Coffee
        public ActionResult Index()
        {
            return View();
        }
        // About 
        public ActionResult About()
        {
            return View();
        }
        // Origins
        public ActionResult Origins()
        {
            return View();
        }
        // List of Competitors
        public ActionResult ListofCompetitors()
        {
            return View();
        }
        // Order Up
        public ActionResult OrderUp()
        {
            return View();
        }
    }
}