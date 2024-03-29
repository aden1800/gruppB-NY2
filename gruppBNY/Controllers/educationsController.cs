﻿using System;
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
    public class educationsController : Controller
    {
        private gruppBEntities1 db = new gruppBEntities1();

        // GET: educations
        public ActionResult Index()
        {
            return View(db.education.ToList());
        }

        // GET: educations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            education education = db.education.Find(id);
            if (education == null)
            {
                return HttpNotFound();
            }
            return View(education);
        }

        // GET: educations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: educations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "education_Id,school_name,education_date,subject,education_degree,freelancer_Id")] education education, int? id)
        {
            if (ModelState.IsValid)
            {
                education.freelancer_id = id;
                db.education.Add(education);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(education);
        }

        // GET: educations/Edit/5
        public ActionResult Edit(int? id, int? id2)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            education education = db.education.Find(id);
            if (education == null)
            {
                return HttpNotFound();
            }
            return View(education);
        }

        // POST: educations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "education_Id,school_name,education_date,subject,education_degree,freelancer_Id")] education education)
        {
            if (ModelState.IsValid)
            {
                db.Entry(education).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Edit");
            }
            return View(education);
        }

        // GET: educations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            education education = db.education.Find(id);
            if (education == null)
            {
                return HttpNotFound();
            }
            return View(education);
        }

        // POST: educations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            education education = db.education.Find(id);
            db.education.Remove(education);
            db.SaveChanges();
            return RedirectToAction("index");
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
