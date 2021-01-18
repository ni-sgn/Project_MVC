using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public static class Initializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person()
                {
                    Id = 1,
                    FirstName = "person1",
                    LastName = "lastname1",
                    PersonalId = "010203030",
                    TypeId = 9,
                    CityId = 7,
                }
                ) ;

            modelBuilder.Entity<SystemDictionary>().HasData(
               new SystemDictionary()
               {
                   Id = 1,
                   HasPosition = true,
                   Name = "System Administrator",
               },
               new SystemDictionary()
               {
                   Id = 2,
                   HasPosition = true,
                   Name = "Judge",
               },
               new SystemDictionary()
               {
                   Id = 3,
                   HasUserType = true,
                   Name = "Admin",
               },
               new SystemDictionary()
               {
                   Id = 4,
                   HasUserType = true,
                   Name = "User",
               }
                ) ;


            modelBuilder.Entity<LawSuit>().HasData(
                new LawSuit()
                {
                    Id = 1,
                    RegistrationDate = new DateTime(1992, 12, 12),
                    ExpirationDate = new DateTime(2000, 12, 23),
                    PersonId = 1,
                    StatusId = 1,
                }
                );

            modelBuilder.Entity<LawSuitDictionary>().HasData(
                new LawSuitDictionary()
                {
                    Id = 1,
                    HasStatus = true,
                    Name = "Ongoing",
                },
                new LawSuitDictionary()
                {
                    Id = 2,
                    HasStatus = true,
                    Name = "Finished",
                },
                new LawSuitDictionary()
                {
                    Id = 3,
                    HasStatus = true,
                    Name = "Rejected",
                },
                new LawSuitDictionary()
                {
                    Id = 4,
                    HasStatus = true,
                    Name = "Stalled",
                },
                 new LawSuitDictionary()
                 {
                     Id = 5,
                     HasPhoneType = true,
                     Name = "Mobile",
                 },
                 new LawSuitDictionary()
                 {
                     Id = 6,
                     HasPhoneType = true,
                     Name = "Home",
                 },
                 new LawSuitDictionary()
                 {
                     Id = 7,
                     HasCity = true,
                     Name = "Tbilisi",
                 },
                 new LawSuitDictionary()
                 {
                     Id = 8,
                     HasCity = true,
                     Name = "Batumi",
                 },
                 new LawSuitDictionary()
                 {
                     Id = 9,
                     HasPersonType = true,
                     Name = "Private",
                 },
                 new LawSuitDictionary()
                 {
                     Id = 10,
                     HasPersonType = true,
                     Name = "Legal",
                 }
                );

            modelBuilder.Entity<PhoneNumber>().HasData(
                new PhoneNumber()
                {
                    Id = 1,
                    Number = "555-555-555",
                    PersonId = 1,
                    TypeId = 5,
                }
                ) ;

        }
    }
}
