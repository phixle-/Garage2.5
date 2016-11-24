namespace Garage2._5.Migrations
{
    using Garage2._5.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage2._5.DataAccess.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Garage2._5.DataAccess.AppContext c)
        {
            
            //string[] types = { "Car", "Truck", "Boat", "Bike" };

            //foreach (var type in types)
            //{
            //    c.VehicleTypes.AddOrUpdate(v => v.Name, new VehicleType { Name = type });
            //}

            c.People.AddOrUpdate(
                p => p.SSN,
                new Person { Name = "Hasse",  SSN = "19760229" },
                new Person { Name = "Svenne", SSN = "19340123" }
            );

            var car = new VehicleType { Name = "Car" };
            c.VehicleTypes.AddOrUpdate(
                vt => vt.Name,
                car
            );

            //c.Vehicles.AddOrUpdate(
            //    v => v.RegNr,
            //    new Vehicle { Color = "Brown", Manufacturer = "Volvo", Model = "240", RegNr = "SKR253", NumberOfWheels = 4, VehicleType = car});

            

            //Person p1 = new Person{ Name = "Hans", PNR = 19760 };
            //var v1 = new Vehicle { RegNr = "JDU736", Color = "Brown", Manufacturer = "Volvo", Model = "240", NumberOfWheels = 4 };
            //c.People.Add(p1);
            //c.SaveChanges();
        }
    }
}
