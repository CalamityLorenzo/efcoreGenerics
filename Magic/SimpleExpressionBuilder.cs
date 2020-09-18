using AutoMapper.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using MyDbApp;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace efcoreGenerics.Magic
{
    class SimpleExpressionBuilder
    {
        public SimpleExpressionBuilder() { }

        public Func<string, T, string> StringAndJoin<T>()
        {
            return (str1, unk1) => String.Concat(str1, unk1);
        }


        public void EdibleVoid()
        {
            // SImple expression
            Func<string, string, string> StringJoin = (str1, str2) => String.Concat(str1, str2);
            // Create an expressions tree from uhm. exressions
            // It is an in memory representation of a lambda expression.
            Expression<Func<string, string, string>> str = (str1, str2) => String.Concat(str1, str2);
            // Expressions are { Paramters, NodeType, Body} with a return type.

            var l = Expression.Parameter(typeof(string), "str1");
            var r = Expression.Parameter(typeof(string), "str2");


        }

        public void ExpressionYear()
        {
            // Expression<Func<ParentOne, int, bool>> YearsAge = (p, i) => p.Year >= 100;
            var parent = Expression.Parameter(typeof(ParentOne), "p");
            var parentYear = Expression.Property(parent, "Year");
            var yearConstant = Expression.Constant(100, typeof(int));
            BinaryExpression body = Expression.GreaterThanOrEqual(parentYear, yearConstant);

            var completeExpression = Expression.Lambda(body, parent);

            Console.WriteLine(completeExpression);
            Console.WriteLine(completeExpression.Body);
            Console.WriteLine(completeExpression.Parameters[0]);

        }

        public void ExpressionYear(int year)
        {
            Expression<Func<ParentOne, int, bool>> d = (p, i) => p.Year >= i;

            var parent = Expression.Parameter(typeof(ParentOne), "p");
            var yearVal = Expression.Parameter(typeof(int), "yr");
            var parentYear = Expression.Property(parent, "Year");
            //var yearConstant = Expression.Constant(100, typeof(int));

            BinaryExpression body = Expression.GreaterThanOrEqual(parentYear, yearVal);

            var completeExpression = Expression.Lambda(body, new[] { yearVal, parent });

            var x = completeExpression.Compile();
            var p = new ParentOne
            {
                Year = 99
            };
            Console.WriteLine(x.DynamicInvoke(year, p));
            Console.WriteLine(completeExpression);
            Console.WriteLine(completeExpression.Body);
            Console.WriteLine(completeExpression.Parameters[0]);
        }

        public void ExpStaticString(string value)
        {
            Expression<Func<string, string, string>> strJoin = (str1, unk1) => String.Concat(str1, unk1);

            var lParam = Expression.Parameter(typeof(string), "str1");
            var rParam = Expression.Parameter(typeof(string), "str2");

            // fetch the method, and ALSO match the paramters (cos it could be ambiguous)
            var method = typeof(string).GetMethod("Concat", new[] { typeof(string), typeof(string) });

            // describes the methid, and paramters
            var body = Expression.Call(method, new[] { lParam, rParam });

            var completeExpression = Expression.Lambda<Func<string, string, string>>(body, lParam, rParam);

            var fullExp = completeExpression.Compile();
            Console.WriteLine(fullExp(value, "William"));
        }

        public void ExpressionSameString(string sameString)
        {
            Expression<Func<ParentOne, string, bool>> exp = (p, str) => p.SameSame == sameString;

            var parentParam = Expression.Parameter(typeof(ParentOne), "p");
            var stringParm = Expression.Parameter(typeof(string), "str");
            var parentSame = Expression.Property(parentParam, "SameSame");
            var body = Expression.Equal(parentSame, stringParm);

            var completeExpression = Expression.Lambda<Func<ParentOne, string, bool>>(body, new[] { parentParam, stringParm });
            var compiledExpression = completeExpression.Compile();
            var p = new ParentOne
            {
                Year = 99,
                SameSame = "Dicky"
            };

            Console.WriteLine(compiledExpression(p, sameString));
        }


        public void CombineExpression(int year, string sameString)
        {
            Expression<Func<ParentOne, string, int, bool>> exp = (p, str, i) => p.SameSame == str && p.Year < i;

            // Parameters = 
            var parentParam = Expression.Parameter(typeof(ParentOne), "p");
            var strParam = Expression.Parameter(typeof(string), "str");
            var intParam = Expression.Parameter(typeof(int), "yr");

            // parernt  members/Properties/Fields required.
            var sameSame = Expression.Property(parentParam, typeof(ParentOne).GetProperty("SameSame"));

            // On the Parent.SameSame, call ToString() no paramters neeeded
            var lowerSame = Expression.Call(sameSame, "ToLower", null);

            var yearP = Expression.Property(parentParam, "Year");

            var left = Expression.Equal(lowerSame, strParam);
            var right = Expression.LessThanOrEqual(yearP, intParam);
            // The body of the Func
            var finalBody = Expression.And(left, right);
            // the form of the Expression, With a func
            var complete = Expression.Lambda<Func<ParentOne, string, int, bool>>(finalBody, new[] { parentParam, strParam, intParam });

            var lv = Expression.Lambda<Func<ParentOne, string, int, bool>>(
                 Expression.And(
                         Expression.Equal(Expression.Call(Expression.Property(parentParam, "SameSame"), "ToLower", null), strParam),
                         Expression.LessThanOrEqual(Expression.Property(parentParam, "Year"), yearP)
                     ), new[] { parentParam, strParam, Expression.Parameter(typeof(int), "Yr") });

            Console.WriteLine(lv);
            //Console.WriteLine(complete);
            var aveit = lv.Compile();
            var p = new ParentOne
            {
                Year = 1000,
                SameSame = "Jelly"
            };
            Console.WriteLine(aveit(p, sameString, year));
        }
    }
}
