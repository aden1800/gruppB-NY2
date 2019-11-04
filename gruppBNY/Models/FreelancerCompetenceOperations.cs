using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gruppBNY.Models;
using gruppBNY.ViewModel;
namespace gruppBNY.Models
{
    public class FreelancerCompetenceOperations
    {
        public List<freelancer_competenceVM> freelancersList()
        {
            using (gruppBEntities1 vmdb = new gruppBEntities1())
            {
                List<freelancer_competenceVM> freelancerCompetencesList = new List<freelancer_competenceVM>();
                var freelancerObj = new gruppBEntities1();
                
                
                //var freelancerlist = (from free in vmdb.freelancer                                    
                //                      join comp in vmdb.competence on free.competence_Id equals
                //                      comp.Freelancer

                //                      select new
                //                      {
                //                          free.Firstname,
                //                          free.Lastname,
                //                          free.Email,
                //                          comp.competences,
                //                          comp.competence_Id
                //                      }).ToList();

                //var freelancerlist = vmdb.Freelancer
                //    .Join(vmdb.freelancer_competence, f => f.freelancer_Id, fc => fc.freelancer_Id, (f, fc) => new { f, fc })
                //    .Join(vmdb.competence, fpc => fpc.fc.competence_Id, c => c.competence_Id, (fpc, c) => new { fpc, c })
                //    .Select(m => new
                //    {
                //        fName = m.fpc.f.Firstname,
                //        lName = m.fpc.f.Lastname,
                //        mail = m.fpc.f.Email,
                //        comp = m.c.competences,
                //        fId = m.fpc.f.freelancer_Id,
                //        cId = m.c.competence_Id
                //    }).ToList();

                //var freelancerlist =
                //    from f in vmdb.Freelancer
                //    join fc in vmdb.freelancer_competence on f.freelancer_Id equals fc.freelancer_Id
                //    join c in vmdb.competence on fc.competence_Id equals c.competence_Id
                //    select new
                //    {
                //        fName = f.Firstname,
                //        lName = f.Lastname,
                //        mail = f.Email,
                //        comp = c.competences,
                //        fId = f.freelancer_Id,
                //        cId = c.competence_Id
                //    };
                //var freelancerList = vmdb.Freelancer.
                //    Join(vmdb.Freelancer, f => f.freelancer_Id, fc => fc.freelancer_Id,
                //    (f, fc) => new { f, fc }).
                //    Join(vmdb.competence, c => c.fc.competence_Id, cf => cf.competence_Id, (c, cf) => new { c, cf })
                //    //.Where(m => m.c.f.freelancer_Id == 1)
                //    .Select(m => new freelancer_competenceVM
                //    {
                //        freelancer_Id = m.c.f.freelancer_Id,
                //        Firstname = m.c.f.Firstname,
                //        Lastname = m.c.f.Lastname,
                //        Email = m.c.f.Email,
                //        competences = m.c.fc.competences,


                //    });
                //foreach (var item in freelancerList)
                //{
                //    Freelancer objvm = new Freelancer();
                //    objvm.Firstname = item.Firstname;
                //    objvm.Lastname = item.Lastname;
                //    objvm.Email = item.Email;
                //    objvm.competences = item.competences;
                //    freelancerCompetencesList.Add(objvm);
                //}
                return freelancerCompetencesList;
            }
        }
    }
}