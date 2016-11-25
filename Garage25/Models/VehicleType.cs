using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage25.Models
{
    public class VehicleType
    {
        [Key]
        public int Id {get;set;}

        [Required]
        public int Type {get;set;}

        [Required]
        public int Vehicle_ID {get;set;}
    }
}