using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using gruppBNY.Models;
using gruppBNY.ViewModel;

namespace gruppBNY.Controllers
{
    public class competencesController : Controller
    {
        private gruppBEntities1 db = new gruppBEntities1();

        // GET: competences
        public ActionResult Index()
        {
          
            return View(db.competence.ToList());
        }

        // GET: competences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            competence competence = db.competence.Find(id);
            if (competence == null)
            {
                return HttpNotFound();
            }
            return View(competence);
        }

        // GET: competences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: competences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "competence_Id,competences,scale, freelancer_Id, category_Id, type_of_competence")] competence competence, int? id)
        {
            if (ModelState.IsValid)
            {
                
                
                competence.freelancer_id = id;
                db.competence.Add(competence);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(competence);
        }

        // GET: competences/Edit/5
        public ActionResult Edit(int? id, int? id2)
        {
            //    if (id == null)
            //    {
            //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //    }
            //    var competenceVM = new competenceVM
            //    {
            //        competence = db.competence.Include(i => i.category).First(i => i.competence_Id == id)
            //    };



            //    if (competenceVM.competence == null)
            //    {
            //        return HttpNotFound();
            //    }
            //    var catList = db.category.ToList();
            //    competenceVM.Allcategories = catList.Select(o => new SelectListItem
            //    {
            //        Text = o.type_of_competence,
            //        Value = o.category_Id.ToString()
            //    });
            //    ViewBag.freelancer_Id = new SelectList(db.Freelancer, "freelancer_Id", "Firstname", competenceVM.competence.freelancer_id);


            //    return View(competenceVM);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
       

            competence competence = db.competence.Find(id);
            
            if (competence == null)
            {
                return HttpNotFound();
            }
        
            
            return View(competence);
        }

        // POST: competences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "competence_Id,competences,scale, freelancer_Id")] competence competence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(competence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(competence);
        }

        // GET: competences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            competence competence = db.competence.Find(id);
            if (competence == null)
            {
                return HttpNotFound();
            }
            return View(competence);
        }

        // POST: competences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, int id2)
        {
            competence competence = db.competence.Find(id);
            
            db.competence.Remove(competence);
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
