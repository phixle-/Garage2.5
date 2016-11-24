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
            Person p1 = new Person{ Name = "Hans", PNR = 19760 };
            var v1 = new Vehicle { RegNr = "JDU736", Color = "Brown", Manufacturer = "Volvo", Model = "240", NumberOfWheels = 4 };
            c.People.Add(p1);
            c.SaveChanges();
        }
    }
}
