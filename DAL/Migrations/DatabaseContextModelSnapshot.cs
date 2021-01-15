﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Entities.LawSuit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("StatusId");

                    b.ToTable("LawSuits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "This is a lawsuit",
                            CreationDate = new DateTime(1992, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpirationDate = new DateTime(2000, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonId = 1,
                            StatusId = 1,
                            Title = "I don't like when someone violates my freedom"
                        });
                });

            modelBuilder.Entity("DAL.Entities.LawSuitDictionary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LawSuitDictionaries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasStatus = true,
                            Name = "Ongoing"
                        },
                        new
                        {
                            Id = 2,
                            HasStatus = true,
                            Name = "Finished"
                        },
                        new
                        {
                            Id = 3,
                            HasStatus = true,
                            Name = "Rejected"
                        },
                        new
                        {
                            Id = 4,
                            HasStatus = true,
                            Name = "Stalled"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Tbilisi",
                            FirstName = "person1",
                            LastName = "lastname1",
                            PersonalId = "010203030",
                            PhoneNumber = "555929292",
                            TypeId = 1
                        });
                });

            modelBuilder.Entity("DAL.Entities.PersonType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PersonTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Private"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Legal"
                        });
                });

            modelBuilder.Entity("DAL.Entities.SystemDictionary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasPosition")
                        .HasColumnType("bit");

                    b.Property<bool>("HasUserType")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SystemDictionaries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasPosition = true,
                            HasUserType = false,
                            Name = "System Administrator"
                        },
                        new
                        {
                            Id = 2,
                            HasPosition = true,
                            HasUserType = false,
                            Name = "Judge"
                        },
                        new
                        {
                            Id = 3,
                            HasPosition = false,
                            HasUserType = true,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 4,
                            HasPosition = false,
                            HasUserType = true,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("DAL.Entities.SystemUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("TypeId");

                    b.ToTable("SystemUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1992, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Name1",
                            LastName = "Lastnam1",
                            PersonalId = "123123112",
                            PositionId = 1,
                            TypeId = 3
                        });
                });

            modelBuilder.Entity("DAL.Entities.LawSuit", b =>
                {
                    b.HasOne("DAL.Entities.Person", "person")
                        .WithMany("LawSuits")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAL.Entities.LawSuitDictionary", "Status")
                        .WithMany("Statuses")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.Person", b =>
                {
                    b.HasOne("DAL.Entities.PersonType", "Type")
                        .WithMany("People")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.SystemUser", b =>
                {
                    b.HasOne("DAL.Entities.SystemDictionary", "Position")
                        .WithMany("UserPositions")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAL.Entities.SystemDictionary", "Type")
                        .WithMany("UserTypes")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
