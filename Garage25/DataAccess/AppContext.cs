using Garage25.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Garage25.DataAccess
{
    public class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection") { }

        public virtual DbSet<VehicleType>   db_VehicleTypes { get; set; }
        public virtual DbSet<Vehicle>       db_Vehicles     { get; set; }
        public virtual DbSet<Person>        db_Persons      { get; set; }
        public virtual DbSet<Owner>         db_Owners       { get; set; }
    }
}