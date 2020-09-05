using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using MyDbApp;

namespace efcoreGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbPath = Path.Combine(System.Environment.CurrentDirectory, "Janky.mdf");
            var connStr = $"Data Source={dbPath};";
            var conn = $"Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=jeepers;Integrated Security=SSPI;";
            Console.WriteLine (conn);
            var optsBuilder = new DbContextOptionsBuilder()
                        .UseSqlServer(conn)
                        .Options;
            using (var ctx = new SimpleDb(optsBuilder))
            {
                ctx.Database.Migrate();

            }
        }
    }
}
