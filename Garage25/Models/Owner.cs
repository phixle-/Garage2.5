using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage25.Models
{
    public class Owner
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}