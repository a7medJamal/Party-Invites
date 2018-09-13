using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Party_Invites.Models
{
    public class GestResponse
    {
       [ Required (ErrorMessage ="Please enter your name")]
        public string Name { set; get; }

        [Required(ErrorMessage ="Please enter your mail")]
     //   [EmailAddress (ErrorMessage = "Please enter avalid mail")]
     //(.) this for any thing
     //(+) this for alot of things
     //(\\@) this for exactily user write @  
     [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Please enter avalid mail")]
        public string Email { get; set; }

        [Required (ErrorMessage ="Please enter your Phone")]
       [Phone(ErrorMessage = "Please enter avalid Number Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Please Choose  ")]
        public bool? WillAttend { get; set; }
    }
}