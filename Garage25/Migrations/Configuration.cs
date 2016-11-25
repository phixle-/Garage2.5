namespace Garage25.Migrations
{
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

        protected override void Seed(Garage25.DataAccess.AppContext context)
        {
            //// Typer
            //var car = new VehicleType { Type = "Car" };
            //var truck = new VehicleType { Type = "Truck" };
            //var boat = new VehicleType { Type = "Boat" };
            //var bike = new VehicleType { Type = "Bike" };
            //c.db_VehicleTypes.AddOrUpdate(vt => vt.Type, car, truck, boat, bike);

            //// Fordon
            //var v1 = new Vehicle { RegNr = "KSU583", Color = "Vit", NumberOfWheels = 4, Manufacturer = "Volvo", Model = "240", VehicleType = car };
            //var v2 = new Vehicle { RegNr = "AUD001", Color = "Svart", NumberOfWheels = 4, Manufacturer = "Audi", Model = "Quattro", VehicleType = car };
            //c.db_Vehicles.AddOrUpdate(v => v.RegNr, v1, v2);

            //// Personer
            //var p1 = new Person { FirstName = "Steve", LastName = "Smith", SSN = "123456789" };
            //var p2 = new Person { FirstName = "Benny", LastName = "hill", SSN = "8765432101" };
            //c.db_Persons.AddOrUpdate(p => p.SSN, p1, p2);

            //// Ägare
            //var o1 = new Owner { PersonId = p1.Id };
            //var o2 = new Owner { PersonId = p2.Id };
            //c.db_Owners.AddOrUpdate(o => o.Person, o1, o2);/
        }
    }
}
