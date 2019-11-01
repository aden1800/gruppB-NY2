using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gruppBNY.ViewModels
{
    public class freelancer_competence
    {
        [Key]
        public int freelancer_Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Email { get; set; }


        [Key]
        public int competence_Id { get; set; }
        public string competences { get; set; }
        public int scale { get; set; }

    }
}