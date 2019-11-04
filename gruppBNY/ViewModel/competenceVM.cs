using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gruppBNY.Models;
using System.Web.Mvc;

namespace gruppBNY.ViewModel
{
    public class competenceVM
    {
        public competence competence { get; set; }
        public IEnumerable<SelectListItem> Allcategories { get; set; }
        private List<int> listofCategories;
        public List<int> ListOfCategories
        {
            get
            {
                if (listofCategories == null)
                {
                    listofCategories = competence.category.Select(m => m.category_Id).ToList();
                }
                return listofCategories;
            }
            set { listofCategories = value; }
        }
    }
}