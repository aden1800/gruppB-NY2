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
    public class FreelancerCustomerController : Controller
    {
        private gruppBEntities1 db = new gruppBEntities1();

        // GET: FreelancerCustomer
        public ActionResult Index()
        {
            return View(db.Freelancer.ToList());
        }

        public ActionResult Search(string value)
        {
            if (value == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            List<Freelancer> freelancerList = db.Freelancer.ToList();
            if (freelancerList == null)
            {
                return HttpNotFound();
            }
            List<Freelancer> freelancers = new List<Freelancer>();
            foreach (var item in freelancerList)
            {
                if (item.Firstname.Contains(value))
                {
                    freelancers.Add(item);
                }
                if (item.Lastname.Contains(value))
                {
                    freelancers.Add(item);
                }
                if (item.Nationality.Contains(value))
                {
                    freelancers.Add(item);
                }
                if (item.Phonenumber.Contains(value))
                {
                    freelancers.Add(item);
                }
                foreach (var item2 in item.competence)
                {
                    if (item2.competences.Contains(value))
                    {
                        freelancers.Add(item);
                    }
                    foreach (var item3 in item2.category)
                    {
                        if (item3.type_of_competence.Contains(value))
                        {
                            freelancers.Add(item);
                        }
                    }
                }
            }
            return View(freelancers);
        }

        // GET: FreelancerCustomer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Freelancer freelancer = db.Freelancer.Find(id);
            if (freelancer == null)
            {
                return HttpNotFound();
            }
            return View(freelancer);
        }

        // GET: FreelancerCustomer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FreelancerCustomer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "freelancer_Id,Firstname,Lastname,Username,Feelancer_Password,Address,Phonenumber,Email,Birthday,BirthCity,Nationality,Drivers_license,Profile_text")] Freelancer freelancer)
        {
            if (ModelState.IsValid)
            {
                db.Freelancer.Add(freelancer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(freelancer);
        }

        // GET: FreelancerCustomer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Freelancer freelancer = db.Freelancer.Find(id);
            if (freelancer == null)
            {
                return HttpNotFound();
            }
            return View(freelancer);
        }

        // POST: FreelancerCustomer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "freelancer_Id,Firstname,Lastname,Username,Feelancer_Password,Address,Phonenumber,Email,Birthday,BirthCity,Nationality,Drivers_license,Profile_text")] Freelancer freelancer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(freelancer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(freelancer);
        }

        // GET: FreelancerCustomer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Freelancer freelancer = db.Freelancer.Find(id);
            if (freelancer == null)
            {
                return HttpNotFound();
            }
            return View(freelancer);
        }

        // POST: FreelancerCustomer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Freelancer freelancer = db.Freelancer.Find(id);
            db.Freelancer.Remove(freelancer);
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
