using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace MyDbApp
{
    public class SimpleDb : DbContext
    {
        public SimpleDb() { }
        public SimpleDb([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<HostOne> HostOnes { get; set; }
        public DbSet<HostTwo> HostTwos { get; set; }

        public DbSet<HOneCore> CoreOne { get; set; }
        public DbSet<HTwoCore> CoreTwo { get; set; }

        public DbSet<HOneSubOne> CoreOneS1 { get; set; }
        public DbSet<HOOneSubTwo> CoreOneS2 { get; set; }

        public DbSet<HTwoSubOne> CoreTwoS1 { get; set; }
        public DbSet<HTwoSubTwo> CoreTwoS2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(System.Environment.CurrentDirectory, "dbOne.db");
            var connStr = $"Data Source={dbPath};";
            var conn = $"Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=jeepers;Integrated Security=SSPI;";
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new H1Builder());
            modelBuilder.ApplyConfiguration(new H2Builder());

            modelBuilder.ApplyConfiguration(new CoreBuilder<HOneCore, HOneSubOne, HOOneSubTwo>());
            modelBuilder.ApplyConfiguration(new CoreBuilder<HOneCore, HOneSubOne, HOOneSubTwo>());

            modelBuilder.Entity<HostOne>().HasData(
                new HostOne
                {
                    Id = 1,
                    Year = 1923,
                    SameSame = "Not the usual",
                    Selfish = DateTime.Now,
                    NoTime = DateTime.Now.Subtract(TimeSpan.FromDays(3f))
                });

            modelBuilder.Entity<HostTwo>().HasData(
                new HostTwo
                {
                    Id = 1,
                    PuffDaddy = "Is a parappa",
                    SameSame = "Another version",
                    NoTime = DateTime.Now.Subtract(TimeSpan.FromDays(3f))
                });

        }
    }
}