using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using gruppBNY.Models;

namespace gruppBNY.Controllers
{
    public class work_historyController : Controller
    {
        private gruppBEntities1 db = new gruppBEntities1();

        // GET: work_history
        public ActionResult Index()
        {
            return View(db.work_history.ToList());
        }

        // GET: work_history/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            work_history work_history = db.work_history.Find(id);
            if (work_history == null)
            {
                return HttpNotFound();
            }
            return View(work_history);
        }

        // GET: work_history/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: work_history/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "work_Id,company,work_position,start_date,end_date,work_duties")] work_history work_history)
        {
            if (ModelState.IsValid)
            {
                db.work_history.Add(work_history);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(work_history);
        }

        // GET: work_history/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            work_history work_history = db.work_history.Find(id);
            if (work_history == null)
            {
                return HttpNotFound();
            }
            return View(work_history);
        }

        // POST: work_history/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "work_Id,company,work_position,start_date,end_date,work_duties")] work_history work_history)
        {
            if (ModelState.IsValid)
            {
                db.Entry(work_history).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(work_history);
        }

        // GET: work_history/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            work_history work_history = db.work_history.Find(id);
            if (work_history == null)
            {
                return HttpNotFound();
            }
            return View(work_history);
        }

        // POST: work_history/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            work_history work_history = db.work_history.Find(id);
            db.work_history.Remove(work_history);
            db.SaveChanges();
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
