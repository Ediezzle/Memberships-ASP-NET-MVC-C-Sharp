using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Memberships.Models
{
    public class Github
    {
        [Required]
        public int MyProperty { get; set; }

        
        public int Property2 { get; set; }


    }
}