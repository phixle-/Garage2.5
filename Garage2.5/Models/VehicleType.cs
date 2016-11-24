using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Garage2._5.Models
{
    public class VehicleType
    {
        //[Key, Column(Order=0)]
        [Key]
        public int Id { get; set; }

        //[Key, Column(Order = 1)]
        //[Index("VehicleType", IsUnique = true)]
        [MaxLength(20)]
        public string Name { get; set; }

        //public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}