using Garage2._5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Garage2._5.DataAccess
{
    public class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection")
        {}

        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<VehicleType> VehiclesTypes { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Person> People { get; set; }
    }
}