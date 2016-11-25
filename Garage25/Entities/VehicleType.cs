using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage25.Entities
{
    public class VehicleType
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Type { get; set; }
    }
}