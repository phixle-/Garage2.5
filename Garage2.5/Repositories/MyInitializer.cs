using Garage2._5.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Garage2._5.Repositories
{
    public class MyInitializer : CreateDatabaseIfNotExists<AppContext>
    //public class MyInitializer : MigrateDatabaseToLatestVersion<AppContext>
    {
        protected override void Seed(AppContext c)
        {
            c.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX IX_Name On VehicleTypes (Name)");
        }
    }
}