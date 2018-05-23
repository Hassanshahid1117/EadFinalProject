using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace project.Models
{
    public class Admin
    {
        public int id { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage = "Please Enter a Valid User Name")]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }
}