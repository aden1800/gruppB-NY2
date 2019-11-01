using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gruppBNY.Models;
using gruppBNY.ViewModel;
namespace gruppBNY.ViewModel
{
    public class freelancer_competenceVM
    {
        public int freelancer_Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Feelancer_Password { get; set; }
        public string Address { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string BirthCity { get; set; }
        public string Nationality { get; set; }
        public Nullable<bool> Drivers_license { get; set; }
        public string Profile_text { get; set; }

        public int competence_Id { get; set; }
        public string competences { get; set; }
        public int scale { get; set; }

    }
}