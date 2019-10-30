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
    public class languagesController : Controller
    {
        private gruppBEntities db = new gruppBEntities();

        // GET: languages
        public ActionResult Index()
        {
            return View(db.languages.ToList());
        }

        // GET: languages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            languages languages = db.languages.Find(id);
            if (languages == null)
            {
                return HttpNotFound();
            }
            return View(languages);
        }

        // GET: languages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: languages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "languages_Id,languages1")] languages languages)
        {
            if (ModelState.IsValid)
            {
                db.languages.Add(languages);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(languages);
        }

        // GET: languages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            languages languages = db.languages.Find(id);
            if (languages == null)
            {
                return HttpNotFound();
            }
            return View(languages);
        }

        // POST: languages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "languages_Id,languages1")] languages languages)
        {
            if (ModelState.IsValid)
            {
                db.Entry(languages).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(languages);
        }

        // GET: languages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            languages languages = db.languages.Find(id);
            if (languages == null)
            {
                return HttpNotFound();
            }
            return View(languages);
        }

        // POST: languages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            languages languages = db.languages.Find(id);
            db.languages.Remove(languages);
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
