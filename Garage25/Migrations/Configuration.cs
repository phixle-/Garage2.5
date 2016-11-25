namespace Garage25.Migrations
{
    using Garage25.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage25.DataAccess.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Garage25.DataAccess.AppContext c)
        {
            string[] types = { "Car", "Truck", "Boat", "Bike" };

            Vehicle v1 = new Vehicle { Id = 1, RegNr = "KSU583", Color = "White", NumberOfWheels = 4, Manufacturer = "Volvo", Model = "240"};
            c.db_Vehicles.AddOrUpdate(
                v => v.RegNr,
                v1
            );

            VehicleType vt1 = new VehicleType { Vehicle_ID = v1.Id, Type = 1 };
            c.db_VehicleTypes.AddOrUpdate(
                vt => vt.Vehicle_ID,
                vt1
            );

            Person p1 = new Person { Id = 1, FirstName = "Steve", LastName = "Smith", SSN = "123456789" };
            c.db_Persons.AddOrUpdate(
                p => p.SSN,
                p1
            );
            
                


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
