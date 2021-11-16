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

            //seed user for testing
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
                 }
             );

            modelBuilder.Entity<Job>().HasData(
                new Job
                {
                    JobId = 1,
                    Position = "manager",
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
                }
            );

        }
    }
}