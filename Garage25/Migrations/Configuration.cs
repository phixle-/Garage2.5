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

            var v1 = new Vehicle { RegNr = "KSU583", Color = "White", NumberOfWheels = 4, Manufacturer = "Volvo", Model = "240"};
            c.db_Vehicles.AddOrUpdate(v => v.RegNr, v1);

            var car = new VehicleType { Type = "Car" };
            c.db_VehicleTypes.AddOrUpdate(vt => vt.Type, car);

            var p1 = new Person { FirstName = "Steve", LastName = "Smith", SSN = "123456789" };
            c.db_Persons.AddOrUpdate(p => p.SSN, p1);
        }
    }
}
