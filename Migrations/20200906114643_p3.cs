using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace efcoreGenerics.Migrations
{
    public partial class p3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParentOnes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NoTime", "Selfish" },
                values: new object[] { new DateTime(2020, 9, 3, 12, 46, 42, 105, DateTimeKind.Local).AddTicks(3763), new DateTime(2020, 9, 6, 12, 46, 42, 102, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "ParentOnes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NoTime", "Selfish" },
                values: new object[] { new DateTime(2020, 9, 6, 12, 46, 42, 105, DateTimeKind.Local).AddTicks(4767), new DateTime(2020, 9, 11, 12, 46, 42, 105, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "ParentTwos",
                keyColumn: "Id",
                keyValue: 1,
                column: "NoTime",
                value: new DateTime(2020, 9, 3, 12, 46, 42, 107, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "ParentTwos",
                keyColumn: "Id",
                keyValue: 2,
                column: "NoTime",
                value: new DateTime(2020, 9, 3, 12, 46, 42, 107, DateTimeKind.Local).AddTicks(5550));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParentOnes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NoTime", "Selfish" },
                values: new object[] { new DateTime(2020, 9, 2, 17, 46, 25, 775, DateTimeKind.Local).AddTicks(8635), new DateTime(2020, 9, 5, 17, 46, 25, 772, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "ParentOnes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NoTime", "Selfish" },
                values: new object[] { new DateTime(2020, 9, 5, 17, 46, 25, 775, DateTimeKind.Local).AddTicks(9480), new DateTime(2020, 9, 10, 17, 46, 25, 775, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "ParentTwos",
                keyColumn: "Id",
                keyValue: 1,
                column: "NoTime",
                value: new DateTime(2020, 9, 2, 17, 46, 25, 777, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "ParentTwos",
                keyColumn: "Id",
                keyValue: 2,
                column: "NoTime",
                value: new DateTime(2020, 9, 2, 17, 46, 25, 777, DateTimeKind.Local).AddTicks(7153));
        }
    }
}
