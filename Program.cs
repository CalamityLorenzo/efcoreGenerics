using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using AutoMapper;
using AutoMapper.Configuration;
using efcoreGenerics.Magic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyDbApp;

namespace efcoreGenerics
{
    class Program
    {
        static ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder
            .AddConsole()
            .AddFilter((category, level) =>
                category == DbLoggerCategory.Database.Command.Name
                && level == LogLevel.Information);
        });

        private static (DbContextOptions opts, IMapper mapper) Setup()
        {
            var cgf = new MapperConfiguration((exp) =>
            {
                exp.CreateMap<P1Core, CoreRepoModel>();
                exp.CreateMap<P2Core, CoreRepoModel>();
                exp.CreateMap<P3Core, CoreRepoModel>();
            });
            var mapper = new Mapper(cgf);
            var conn = $"Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=efcoreGenerics;Integrated Security=SSPI;";
            Console.WriteLine(conn);
            var optsBuilder = new DbContextOptionsBuilder()
                        .UseSqlServer(conn)
                        .UseLoggerFactory(loggerFactory)
                        .Options;
            return (optsBuilder, mapper);
        }
        static void Main(string[] args)
        {

            (var opts, var mapper) = Setup();


            var simpleExp = new SimpleExpressionBuilder();
            //simpleExp.ExpressionYear(25);
            simpleExp.ExpStaticString("Dicky");
            simpleExp.ExpStaticString("Puddle");

            simpleExp.CombineExpression(1000, "jelly");
            simpleExp.CombineExpression(1000, "Toby");

            //using (var ctx = new DbAppContext(opts))
            //{
            //    ctx.Database.Migrate();

            //    var cR = new CoreRepoBasic<P1Core, P1Sub1, P1Sub2>(ctx, null);
            //    //var subs = cR.GetSubsForParentId(1);
            //    var core = cR.GetCoreForSub(2).ToList();

            //}
        }
    }
}
