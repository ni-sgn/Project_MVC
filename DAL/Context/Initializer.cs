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
                    City = "Tbilisi",
                    PersonalId = "010203030",
                    PhoneNumber = "555929292",
                    TypeId = 1,
                }
                ) ;

            modelBuilder.Entity<PersonType>().HasData(
                new PersonType()
                {
                    Id = 1,
                    Name = "Private",
                },
                new PersonType()
                {
                    Id = 2,
                    Name = "Legal",
                }
                ) ;


            modelBuilder.Entity<SystemUser>().HasData(
                new SystemUser()
                {
                    Id = 1,
                    FirstName = "Name1",
                    LastName = "Lastnam1",
                    PersonalId = "123123112",
                    BirthDate = new DateTime(1992,02,23),
                    PositionId = 1,
                    TypeId = 3
                }
                );

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
                    Body = "This is a lawsuit",
                    Title = "I don't like when someone violates my freedom",
                    CreationDate = new DateTime(1992, 12, 12),
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
                }
                ) ;

        }
    }
}
