using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using gruppBNY.Models;
using gruppBNY.ViewModels;

namespace gruppBNY.Controllers
{
    public class freelancer_competenceController : Controller
    {
        // GET: FreelancerCompetenceDetail
        public ActionResult Index()
        {
            freelancer_competenceOperations fcop = new freelancer_competenceOperations();
         
            return View(fcop.freelancersList());
        }
    }
}