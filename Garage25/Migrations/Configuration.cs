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
            // Typer
            var car = new VehicleType { Type = "Car" };
            c.db_VehicleTypes.AddOrUpdate(vt => vt.Type, car);

            var truck = new VehicleType { Type = "Truck" };
            c.db_VehicleTypes.AddOrUpdate(vt => vt.Type, truck);

            var boat = new VehicleType { Type = "Boat" };
            c.db_VehicleTypes.AddOrUpdate(vt => vt.Type, boat);

            var bike = new VehicleType { Type = "Bike" };
            c.db_VehicleTypes.AddOrUpdate(vt => vt.Type, truck);

            // Fordon
            var v1 = new Vehicle { RegNr = "KSU583", Color = "Vit", NumberOfWheels = 4, Manufacturer = "Volvo", Model = "240"};
            c.db_Vehicles.AddOrUpdate(v => v.RegNr, v1);

            var v2 = new Vehicle { RegNr = "AUD001", Color = "Svart", NumberOfWheels = 4, Manufacturer = "Audi", Model = "Quattro"};
            c.db_Vehicles.AddOrUpdate(v => v.RegNr, v2);

            // Personer
            var p1 = new Person { FirstName = "Steve", LastName = "Smith", SSN = "123456789" };
            c.db_Persons.AddOrUpdate(p => p.SSN, p1);

            var p2 = new Person { FirstName = "Benny", LastName = "hill", SSN = "8765432101" };
            c.db_Persons.AddOrUpdate(p => p.SSN, p2);

            // Ägare
        }
    }
}
