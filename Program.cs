using System;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyDbApp;

namespace efcoreGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                .AddConsole()
                .AddFilter((category, level) =>
                    category == DbLoggerCategory.Database.Command.Name
                    && level == LogLevel.Information);
            });

            var conn = $"Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=efcoreGenerics;Integrated Security=SSPI;";
            Console.WriteLine (conn);
            var optsBuilder = new DbContextOptionsBuilder()
                        .UseSqlServer(conn)
                        .UseLoggerFactory(loggerFactory)
                        .Options;
            using (var ctx = new DbAppContext(optsBuilder))
            {
                ctx.Database.Migrate();

                var cR = new CoreRepoBasic<P1Core, P1Sub1, P1Sub2>(ctx, null);
                //var subs = cR.GetSubsForParentId(1);
                var core = cR.GetCoreForSub(2).ToList();

            }
        }
    }
}
