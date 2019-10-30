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
    public class core_abilitiesController : Controller
    {
        private gruppBEntities db = new gruppBEntities();

        // GET: core_abilities
        public ActionResult Index()
        {
            return View(db.core_abilities.ToList());
        }

        // GET: core_abilities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            core_abilities core_abilities = db.core_abilities.Find(id);
            if (core_abilities == null)
            {
                return HttpNotFound();
            }
            return View(core_abilities);
        }

        // GET: core_abilities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: core_abilities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "core_abilities_Id,ability")] core_abilities core_abilities)
        {
            if (ModelState.IsValid)
            {
                db.core_abilities.Add(core_abilities);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(core_abilities);
        }

        // GET: core_abilities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            core_abilities core_abilities = db.core_abilities.Find(id);
            if (core_abilities == null)
            {
                return HttpNotFound();
            }
            return View(core_abilities);
        }

        // POST: core_abilities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "core_abilities_Id,ability")] core_abilities core_abilities)
        {
            if (ModelState.IsValid)
            {
                db.Entry(core_abilities).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(core_abilities);
        }

        // GET: core_abilities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            core_abilities core_abilities = db.core_abilities.Find(id);
            if (core_abilities == null)
            {
                return HttpNotFound();
            }
            return View(core_abilities);
        }

        // POST: core_abilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            core_abilities core_abilities = db.core_abilities.Find(id);
            db.core_abilities.Remove(core_abilities);
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
