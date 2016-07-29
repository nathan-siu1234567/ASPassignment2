using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPAssignment2.Models;


namespace ASPAssignment2.Controllers
{
    public class HomeController : Controller
    {
        FoodEntities foodDB = new FoodEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {

            var foodName = foodDB.food.ToList();
            return View(foodName);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Information";

            return View();
        }
       
       
    }
}