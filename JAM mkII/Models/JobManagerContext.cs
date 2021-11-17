using System;
using Microsoft.EntityFrameworkCore;

namespace JAM_mkII.Models
{
    public class JobManagerContext : DbContext
    {
        public JobManagerContext(DbContextOptions<JobManagerContext> options)
            : base(options)
        {
        }


        public DbSet<Application> Applications { get; set; }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Result> Results { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            // code that configures the DbContext goes here
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // code that configures the DbSet entities goes here
            base.OnModelCreating(modelBuilder);

            //seed data for testing / demonstration
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Ssn = "000-00-0001",
                    FName = "Trogdor",
                    LName = "Burninator",
                    DoB = new DateTime(2021, 01, 01),
                    Phone = "555-1212",
                    Address = "Countryside",
                    Position = 1
                },
                new User
                {
                    UserId = 2,
                    Ssn = "123-45-6789",
                    FName = "John",
                    LName = "Wayne",
                    DoB = new DateTime(1934, 01, 01),
                    Phone = "555-4242",
                    Address = "southside",
                    Position = 3
                },
                new User
                {
                    UserId = 3,
                    Ssn = "987-65-4321",
                    FName = "Tammy",
                    LName = "Baker",
                    DoB = new DateTime(1995, 01, 01),
                    Phone = "555-3578",
                    Address = "Portland",
                    Position = 2
                },
                new User
                {
                    UserId = 4,
                    Ssn = "556-28-1867",
                    FName = "Larry",
                    LName = "Linville",
                    DoB = new DateTime(1981, 01, 01),
                    Phone = "555-8946",
                    Address = "Annaville",
                    Position = 2
                }
            );

            modelBuilder.Entity<Job>().HasData(
                new Job
                {
                    JobId = 1,
                    PositionId = 2,
                    StoreId = 2,
                    OpenDate = new DateTime(2021, 11, 16),
                    CloseDate = new DateTime(2021, 12, 31)
                },
                new Job
                {
                    JobId = 2,
                    PositionId = 3,
                    StoreId = 4,
                    OpenDate = new DateTime(2021, 11, 16),
                    CloseDate = new DateTime(2021, 12, 31)
                },
                new Job
                {
                    JobId = 3,
                    PositionId = 2,
                    StoreId = 1,
                    OpenDate = new DateTime(2021, 11, 16),
                    CloseDate = new DateTime(2021, 12, 31)
                },
                new Job
                {
                    JobId = 4,
                    PositionId = 2,
                    StoreId = 2,
                    OpenDate = new DateTime(2021, 11, 16),
                    CloseDate = new DateTime(2021, 12, 31)
                }
            );


            modelBuilder.Entity<Store>().HasData(
                new Store
                {
                    StoreId = 1,
                    Location = "Airline",
                    ManagerId = 1,
                    StaffReq = 2
                },
                new Store
                {
                    StoreId = 2,
                    Location = "Airline",
                    ManagerId = 1,
                    StaffReq = 4
                },
                new Store
                {
                    StoreId = 3,
                    Location = "Staples",
                    ManagerId = 4,
                    StaffReq = 4
                },
                new Store
                {
                    StoreId = 4,
                    Location = "SPID",
                    ManagerId = 2,
                    StaffReq = 6
                }
            );

            modelBuilder.Entity<Position>().HasData(
                new Position
                {
                    PositionId = 1,
                    PositionName = "Applicant"
                },
                new Position
                {
                    PositionId = 2,
                    PositionName = "Counter Staff"
                },
                new Position
                {
                    PositionId = 3,
                    PositionName = "Shift Manager"
                },
                new Position
                {
                    PositionId = 4,
                    PositionName = "Manager"
                },
                new Position
                {
                    PositionId = 5,
                    PositionName = "Owner"
                }

            );
            modelBuilder.Entity<Result>().HasData(
                new Result
                {
                    ResultId = 1,
                    Hired = false,
                    Comments = "couldn't pass test"
                },
                new Result
                {
                    ResultId = 2,
                    Hired = false,
                    Comments = "failed to show for interview"
                },
                new Result
                {
                    ResultId = 3,
                    Hired = true,
                    Comments = "excellent candidate"
                }
            );
        }
    }
}