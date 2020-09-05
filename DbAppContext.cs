using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace MyDbApp
{
    public class DbAppContext : DbContext
    {
        public DbAppContext() { }
        public DbAppContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<ParentOne> ParentOnes { get; set; }
        public DbSet<ParentTwo> ParentTwos { get; set; }

        public DbSet<P1Core> CoreOne { get; set; }
        public DbSet<P2Core> CoreTwo { get; set; }

        public DbSet<P1Sub1> CoreOneS1 { get; set; }
        public DbSet<P1Sub2> CoreOneS2 { get; set; }

        public DbSet<P2Sub2> CoreTwoS1 { get; set; }
        public DbSet<P2SubOne> CoreTwoS2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(System.Environment.CurrentDirectory, "dbOne.db");
            var connStr = $"Data Source={dbPath};";
            var conn = $"Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=efcoreGenerics;Integrated Security=SSPI;";
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new P1Builder());
            modelBuilder.ApplyConfiguration(new P2Builder());

            modelBuilder.ApplyConfiguration(new CoreBuilder<P1Core, P1Sub1, P1Sub2>());
            modelBuilder.ApplyConfiguration(new CoreBuilder<P1Core, P1Sub1, P1Sub2>());

            modelBuilder.Entity<ParentOne>().HasData(
                new ParentOne
                {
                    Id = 1,
                    Year = 1923,
                    SameSame = "Not the usual",
                    Selfish = DateTime.Now,
                    NoTime = DateTime.Now.Subtract(TimeSpan.FromDays(3f))
                },
                new ParentOne
                {
                    Id = 2,
                    Year = 1878,
                    SameSame = "PLAAAAANK",
                    Selfish = DateTime.Now.AddDays(5f),
                    NoTime = DateTime.Now
                });

            modelBuilder.Entity<ParentTwo>().HasData(
                new ParentTwo
                {
                    Id = 1,
                    PuffDaddy = "Is a parappa",
                    SameSame = "Another version",
                    NoTime = DateTime.Now.Subtract(TimeSpan.FromDays(3f))
                },
                new ParentTwo
                {
                    Id = 2,
                    PuffDaddy = "Pointiny",
                    SameSame = "Number two",
                    NoTime = DateTime.Now.Subtract(TimeSpan.FromDays(3f))
                });

            modelBuilder.Entity<P1Core>().HasData(
                new P1Core
                {
                    Id = 1,
                    HostId = 2,
                    Name = "P1-Core 1"
                },
                new P1Core
                {
                    Id = 2,
                    HostId = 2,
                    Name = "P1-Core 2"
                });

            modelBuilder.Entity<P2Core>().HasData(
                new P2Core
                {
                    HostId = 1,
                    Id = 1,
                    Name = "P2-Core 1"
                },
                new P2Core
                {
                    HostId = 2,
                    Id = 2,
                    Name = "P2-Core 2"
                },
                new P2Core
                {
                    HostId = 1,
                    Id = 3,
                    Name = "P3-Core 2"
                });


            modelBuilder.Entity<P1Sub2>().HasData(
                new P1Sub2
                {
                    Id = 1,
                    HostId = 1,
                    IsAOkay = false,
                    Name = "Matilda"
                },
                new P1Sub2
                {
                    Id = 2,
                    HostId = 1,
                    IsAOkay = true,
                    Name = "Claming"
                },
                new P1Sub2
                {
                    Id = 3,
                    HostId = 2,
                    IsAOkay = false,
                    Name = "Cujo"
                });

        }
    }
}