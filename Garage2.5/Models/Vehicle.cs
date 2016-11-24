using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2._5.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(6), MaxLength(7)]
        public string RegNr { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public int NumberOfWheels { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public virtual VehicleType VehicleType { get; set; }

        public virtual Owner Owner { get; set; }
    }
}