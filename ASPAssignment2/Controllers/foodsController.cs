using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPAssignment2.Models;

namespace ASPAssignment2.Controllers
{
    public class foodsController : Controller
    {
        private FoodContext db = new FoodContext();

        // GET: foods
        public async Task<ActionResult> Index()
        {
            return View(await db.Food.ToListAsync());
        }

        // GET: foods/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            food food = await db.Food.FindAsync(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        // GET: foods/Create
        public ActionResult Create()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
