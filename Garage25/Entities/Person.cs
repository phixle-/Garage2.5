﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage25.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(8), MaxLength(12)]
        public string SSN { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public virtual Owner Owner { get; set; }
    }
}