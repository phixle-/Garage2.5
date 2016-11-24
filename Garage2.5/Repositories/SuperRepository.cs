﻿//using Garage2._5.DataAccess;
//using Garage2._5.Models;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Web;

//namespace Garage2._5.Repositories
//{
//    public class SuperRepository
//    {
//        private AppContext db = new AppContext();

//        public int MyProperty { get; set; }

//        public void Dispose()
//        {
//            db.Dispose();
//        }

//        #region Person

//        public IEnumerable<Person> GetPeople()
//        {
//            return db.People;
//        }

//        public Person FindPersonById(int? id)
//        { 
//            return db.People.Find(id);
//        }

//        public IEnumerable<Owner> GetAllOwners()
//        {
//            return db.Owners;
//        }

//        public void AddPerson(Person p)
//        {
//            db.People.Add(p);
//            db.SaveChanges();
//        }

//        public void UpdatePerson(Person p)
//        {
//            db.Entry(p).State = EntityState.Modified;
//            db.SaveChanges();
//        }

//        public void RemovePerson(Person p)
//        {
//            db.People.Remove(p);
//            db.SaveChanges();
//        }

//        public void MakeOwner(Vehicle v, Person p)
//        {

//        }

//        public void BecomeOwner(int id)
//        {
//            //db.Owners.Add(new Owner { PersonId = id });
//            db.SaveChanges();
//        }

//        public void AddVehicle(Vehicle v, Owner o)
//        {

//        }

//        #endregion

//        #region VehicleType

//        public List<VehicleType> GetAllVehicleTypes()
//        {
//            return db.VehicleTypes.ToList();
//        }

//        public VehicleType FindVehicleTypeById(int? id)
//        {
//            return db.VehicleTypes.Find(id);
//        }

//        public void AddVehicleType(VehicleType vt)
//        {
//            db.VehicleTypes.Add(vt);
//            db.SaveChanges();
//        }

//        public void VehicleTypeEntry(VehicleType vt)
//        {
//            db.Entry(vt).State = EntityState.Modified;
//            db.SaveChanges();
//        }

//        public void VehicleTypeRemove(int id)
//        {
//            db.VehicleTypes.Remove(FindVehicleTypeById(id));
//            db.SaveChanges();
//        }

//        #endregion

//        #region Vehicle

//        public List<Vehicle> GetAllVehicles()
//        {
//            return db.Vehicles.ToList();
//        }

//        public Vehicle FindVehicleById(int? id)
//        {
//            return db.Vehicles.Find(id);
//        }

//        public void AddVehicle(Vehicle v)
//        {
//            db.Vehicles.Add(v);
//            db.SaveChanges();
//        }

//        public void VehicleEntry(Vehicle v)
//        {
//            db.Entry(v).State = EntityState.Modified;
//            db.SaveChanges();
//        }

//        public void RemoveVehicle(int id)
//        {
//            db.Vehicles.Remove(FindVehicleById(id));
//            db.SaveChanges();
//        }

//        #endregion
//    }
//}