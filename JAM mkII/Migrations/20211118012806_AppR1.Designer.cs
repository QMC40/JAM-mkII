﻿// <auto-generated />
using System;
using JAM_mkII.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JAM_mkII.Migrations
{
    [DbContext(typeof(JobManagerContext))]
    [Migration("20211118012806_AppR1")]
    partial class AppR1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JAM_mkII.Models.Application", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ApplyDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Disqualified")
                        .HasColumnType("bit");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<bool>("PassedTest")
                        .HasColumnType("bit");

                    b.Property<int>("ResultId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ApplicationId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("JAM_mkII.Models.Employment", b =>
                {
                    b.Property<int>("EmploymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StopDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmploymentId");

                    b.ToTable("Employments");
                });

            modelBuilder.Entity("JAM_mkII.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CloseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OpenDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("JobId");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            JobId = 1,
                            CloseDate = new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OpenDate = new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PositionId = 2,
                            StoreId = 2
                        },
                        new
                        {
                            JobId = 2,
                            CloseDate = new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OpenDate = new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PositionId = 3,
                            StoreId = 4
                        },
                        new
                        {
                            JobId = 3,
                            CloseDate = new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OpenDate = new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PositionId = 2,
                            StoreId = 1
                        },
                        new
                        {
                            JobId = 4,
                            CloseDate = new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OpenDate = new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PositionId = 2,
                            StoreId = 2
                        });
                });

            modelBuilder.Entity("JAM_mkII.Models.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PositionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            PositionId = 1,
                            PositionName = "Applicant"
                        },
                        new
                        {
                            PositionId = 2,
                            PositionName = "Counter Staff"
                        },
                        new
                        {
                            PositionId = 3,
                            PositionName = "Shift Manager"
                        },
                        new
                        {
                            PositionId = 4,
                            PositionName = "Manager"
                        },
                        new
                        {
                            PositionId = 5,
                            PositionName = "Owner"
                        });
                });

            modelBuilder.Entity("JAM_mkII.Models.Result", b =>
                {
                    b.Property<int>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Hired")
                        .HasColumnType("bit");

                    b.HasKey("ResultId");

                    b.ToTable("Results");

                    b.HasData(
                        new
                        {
                            ResultId = 1,
                            Comments = "couldn't pass test",
                            Hired = false
                        },
                        new
                        {
                            ResultId = 2,
                            Comments = "failed to show for interview",
                            Hired = false
                        },
                        new
                        {
                            ResultId = 3,
                            Comments = "excellent candidate",
                            Hired = true
                        });
                });

            modelBuilder.Entity("JAM_mkII.Models.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<int>("StaffReq")
                        .HasColumnType("int");

                    b.HasKey("StoreId");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            StoreId = 1,
                            Location = "Airline",
                            ManagerId = 1,
                            StaffReq = 2
                        },
                        new
                        {
                            StoreId = 2,
                            Location = "Airline",
                            ManagerId = 1,
                            StaffReq = 4
                        },
                        new
                        {
                            StoreId = 3,
                            Location = "Staples",
                            ManagerId = 4,
                            StaffReq = 4
                        },
                        new
                        {
                            StoreId = 4,
                            Location = "SPID",
                            ManagerId = 2,
                            StaffReq = 6
                        });
                });

            modelBuilder.Entity("JAM_mkII.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<string>("Ssn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Address = "Countryside",
                            DoB = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Trogdor",
                            LName = "Burninator",
                            Phone = "555-1212",
                            Position = 1,
                            Ssn = "000-00-0001"
                        },
                        new
                        {
                            UserId = 2,
                            Address = "southside",
                            DoB = new DateTime(1934, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "John",
                            LName = "Wayne",
                            Phone = "555-4242",
                            Position = 3,
                            Ssn = "123-45-6789"
                        },
                        new
                        {
                            UserId = 3,
                            Address = "Portland",
                            DoB = new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Tammy",
                            LName = "Baker",
                            Phone = "555-3578",
                            Position = 2,
                            Ssn = "987-65-4321"
                        },
                        new
                        {
                            UserId = 4,
                            Address = "Annaville",
                            DoB = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FName = "Larry",
                            LName = "Linville",
                            Phone = "555-8946",
                            Position = 2,
                            Ssn = "556-28-1867"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
