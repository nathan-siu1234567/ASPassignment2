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
        public async Task<ActionResult> Menu()
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

        // POST: foods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FoodID,foodImageUrl,Name,Price,shortDescription,Description")] food food)
        {
            if (ModelState.IsValid)
            {
                db.Food.Add(food);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(food);
        }

        // GET: foods/Edit/5
        public async Task<ActionResult> Edit(int? id)
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

        // POST: foods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FoodID,foodImageUrl,Name,Price,shortDescription,Description")] food food)
        {
            if (ModelState.IsValid)
            {
                db.Entry(food).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(food);
        }

        // GET: foods/Delete/5
        public async Task<ActionResult> Delete(int? id)
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

        // POST: foods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            food food = await db.Food.FindAsync(id);
            db.Food.Remove(food);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
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
