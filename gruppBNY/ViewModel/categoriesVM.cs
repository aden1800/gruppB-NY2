using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gruppBNY.Models;
using System.Web.Mvc;
namespace gruppBNY.ViewModel
{
    public class categoriesVM
    {
        public category category { get; set; }
        public IEnumerable<SelectListItem> Allcategories { get; set; }
    }
}