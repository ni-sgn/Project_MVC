using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<SystemDictionary> SystemDictionaries { get; set; }
        public DbSet<LawSuit> LawSuits { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonType> PersonTypes { get; set; }
        public DbSet<LawSuitDictionary> LawSuitDictionaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SystemUser>()
                .Property(e => e.FirstName)
                .IsRequired();
            modelBuilder.Entity<SystemUser>()
                .Property(e => e.LastName)
                .IsRequired();
            modelBuilder.Entity<SystemUser>()
                .Property(e => e.PersonalId)
                .IsRequired();
            modelBuilder.Entity<SystemUser>()
                .Property(e => e.BirthDate)
                .IsRequired();

            modelBuilder.Entity<SystemUser>()
                .HasOne(e => e.Position)
                .WithMany(e => e.UserPositions)
                .HasForeignKey(e => e.PositionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SystemUser>()
                .HasOne(e => e.Type)
                .WithMany(e => e.UserTypes)
                .HasForeignKey(e => e.TypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LawSuit>()
                .HasOne(e => e.person)
                .WithMany(e => e.LawSuits)
                .HasForeignKey(e => e.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Person>()
                .HasOne(e => e.Type)
                .WithMany(e => e.People)
                .HasForeignKey(e => e.TypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Seed();
        }
        
    }
}
