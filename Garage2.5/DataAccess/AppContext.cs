using Garage2._5.Models;
using Garage2._5.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Web;

namespace Garage2._5.DataAccess
{
    public class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection")
        { 
            // Database.SetInitializer<AppContext>(new MyInitializer()); 
        }

        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<VehicleType> VehicleTypes { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VehicleType>()
                .Property(t => t.Name)
                .IsRequired()
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("IX_Name", 1) { IsUnique = true }));

            modelBuilder.Entity<Person>()
                .Property(t => t.SSN)
                .IsRequired()
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("IX_SSN", 1) { IsUnique = true }));

            modelBuilder.Entity<Vehicle>()
                .Property(t => t.RegNr)
                .IsRequired()
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("IX_RegNr", 1) { IsUnique = true }));
        }
    }
}