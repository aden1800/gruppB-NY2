using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gruppBNY.Models;
using gruppBNY.ViewModels;
namespace gruppBNY.Models
{
    public class freelancer_competenceOperations
    {
        public List<freelancer_competence> freelancersList()
        {
            gruppBEntities vmdb = new gruppBEntities();        
            List<freelancer_competence> freelancerCompetencesList = new List<freelancer_competence>();
            var freelancerlist = (from comp in vmdb.competence
                              join free in vmdb.Freelancer on comp.competence_Id equals
                              free.freelancer_Id
                              select new
                              {
                                  free.Firstname,
                                  free.Lastname,
                                  free.Email,
                                  comp.competences
                              }).ToList();

            foreach (var item in freelancerlist)
            {
                freelancer_competence objvm = new freelancer_competence();
                objvm.Firstname = item.Firstname;
                objvm.Lastname = item.Lastname;
                objvm.Email = item.Email;
                objvm.competences = item.competences;
                freelancerCompetencesList.Add(objvm);
            }
            return freelancerCompetencesList;
        }

    }
}