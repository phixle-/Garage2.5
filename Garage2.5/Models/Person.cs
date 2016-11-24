using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2._5.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public int PNR { get; set; }
        
        [Required]
        public string Name { get; set; }

        public virtual Owner Owner { get; set; }
    }
}