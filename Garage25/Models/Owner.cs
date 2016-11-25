using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Garage25.Models
{
    public class Owner
    {
        [Key, ForeignKey("Person")]
        public int PersonId { get; set; }

        public virtual Person Person { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}