using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DAL.Context
{
    public class DatabaseContext : IdentityDbContext<SystemUser>
    {
        public DatabaseContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<SystemDictionary> SystemDictionaries { get; set; }
        public DbSet<LawSuit> LawSuits { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<LawSuitDictionary> LawSuitDictionaries { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SystemUser>()
                .Property(e => e.FirstName)
                .IsRequired();
            modelBuilder.Entity<SystemUser>()
                .Property(e => e.LastName)
                .IsRequired();

            modelBuilder.Entity<LawSuit>()
                .HasOne(e => e.person)
                .WithMany(e => e.LawSuits)
                .HasForeignKey(e => e.PersonId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<LawSuit>()
                .HasOne(e => e.Status)
                .WithMany(e => e.LawSuits)
                .HasForeignKey(e => e.StatusId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Person>()
                .HasOne(e => e.Type)
                .WithMany(e => e.PersonTypes)
                .HasForeignKey(e => e.TypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Person>()
                .HasOne(e => e.City)
                .WithMany(e => e.PersonCities)
                .HasForeignKey(e => e.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhoneNumber>()
                .HasOne(e => e.person)
                .WithMany(e => e.Numbers)
                .HasForeignKey(e => e.PersonId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PhoneNumber>()
                .HasOne(e => e.Type)
                .WithMany(e => e.Numbers)
                .HasForeignKey(e => e.TypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Seed();
        }
        
    }
}
