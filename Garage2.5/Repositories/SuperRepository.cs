using Garage2._5.DataAccess;
using Garage2._5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Garage2._5.Repositories
{
    public class SuperRepository
    {
        private AppContext db = new AppContext();

        public int MyProperty { get; set; }

        public IEnumerable<Person> GetPeople()
        {
            return db.People;
        }

        public Person FindPersonById(int? id)
        { 
            return db.People.Find(id);
        }

        public IEnumerable<Owner> GetAllOwners()
        {
            return db.Owners;
        }

        public void AddPerson(Person p)
        {
            db.People.Add(p);
            db.SaveChanges();
        }

        public void UpdatePerson(Person p)
        {
            db.Entry(p).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void RemovePerson(Person p)
        {
            db.People.Remove(p);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void MakeOwner(Vehicle v, Person p)
        {

        }

        public void BecomeOwner(int id)
        {
            db.Owners.Add(new Owner { PersonId = id});
        }

        public void AddVehicle(Vehicle v, Owner o)
        {

        }
    }
}