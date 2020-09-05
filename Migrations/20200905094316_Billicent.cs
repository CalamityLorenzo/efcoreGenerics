using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace efcoreGenerics.Migrations
{
    public partial class Billicent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HostOnes",
                columns: new[] { "Id", "NoTime", "SameSame", "Selfish", "Year" },
                values: new object[] { 1, new DateTime(2020, 9, 2, 10, 43, 15, 326, DateTimeKind.Local).AddTicks(6152), "Not the usual", new DateTime(2020, 9, 5, 10, 43, 15, 321, DateTimeKind.Local).AddTicks(913), 1923 });

            migrationBuilder.InsertData(
                table: "HostTwos",
                columns: new[] { "Id", "NoTime", "PuffDaddy", "SameSame" },
                values: new object[] { 1, new DateTime(2020, 9, 2, 10, 43, 15, 329, DateTimeKind.Local).AddTicks(4928), "Is a parappa", "Another version" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HostOnes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HostTwos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
