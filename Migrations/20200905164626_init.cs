using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace efcoreGenerics.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParentOnes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(nullable: false),
                    SameSame = table.Column<string>(nullable: true),
                    Selfish = table.Column<DateTime>(nullable: false),
                    NoTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentOnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParentTwos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PuffDaddy = table.Column<string>(nullable: true),
                    SameSame = table.Column<string>(nullable: true),
                    NoTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentTwos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoreOne",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreOne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoreOne_ParentOnes_HostId",
                        column: x => x.HostId,
                        principalTable: "ParentOnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoreTwo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreTwo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoreTwo_ParentTwos_HostId",
                        column: x => x.HostId,
                        principalTable: "ParentTwos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoreOneS1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostId = table.Column<int>(nullable: false),
                    Numbers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreOneS1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoreOneS1_CoreOne_HostId",
                        column: x => x.HostId,
                        principalTable: "CoreOne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoreOneS2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsAOkay = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreOneS2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoreOneS2_CoreOne_HostId",
                        column: x => x.HostId,
                        principalTable: "CoreOne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoreTwoS1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostId = table.Column<int>(nullable: false),
                    Numbers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreTwoS1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoreTwoS1_CoreTwo_HostId",
                        column: x => x.HostId,
                        principalTable: "CoreTwo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoreTwoS2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsAOkay = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreTwoS2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoreTwoS2_CoreTwo_HostId",
                        column: x => x.HostId,
                        principalTable: "CoreTwo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ParentOnes",
                columns: new[] { "Id", "NoTime", "SameSame", "Selfish", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 2, 17, 46, 25, 775, DateTimeKind.Local).AddTicks(8635), "Not the usual", new DateTime(2020, 9, 5, 17, 46, 25, 772, DateTimeKind.Local).AddTicks(8271), 1923 },
                    { 2, new DateTime(2020, 9, 5, 17, 46, 25, 775, DateTimeKind.Local).AddTicks(9480), "PLAAAAANK", new DateTime(2020, 9, 10, 17, 46, 25, 775, DateTimeKind.Local).AddTicks(9447), 1878 }
                });

            migrationBuilder.InsertData(
                table: "ParentTwos",
                columns: new[] { "Id", "NoTime", "PuffDaddy", "SameSame" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 2, 17, 46, 25, 777, DateTimeKind.Local).AddTicks(6462), "Is a parappa", "Another version" },
                    { 2, new DateTime(2020, 9, 2, 17, 46, 25, 777, DateTimeKind.Local).AddTicks(7153), "Pointiny", "Number two" }
                });

            migrationBuilder.InsertData(
                table: "CoreOne",
                columns: new[] { "Id", "HostId", "Name" },
                values: new object[,]
                {
                    { 1, 2, "P1-Core 1" },
                    { 2, 2, "P1-Core 2" }
                });

            migrationBuilder.InsertData(
                table: "CoreTwo",
                columns: new[] { "Id", "HostId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "P2-Core 1" },
                    { 3, 1, "P3-Core 2" },
                    { 2, 2, "P2-Core 2" }
                });

            migrationBuilder.InsertData(
                table: "CoreOneS2",
                columns: new[] { "Id", "HostId", "IsAOkay", "Name" },
                values: new object[] { 1, 1, false, "Matilda" });

            migrationBuilder.InsertData(
                table: "CoreOneS2",
                columns: new[] { "Id", "HostId", "IsAOkay", "Name" },
                values: new object[] { 2, 1, true, "Claming" });

            migrationBuilder.InsertData(
                table: "CoreOneS2",
                columns: new[] { "Id", "HostId", "IsAOkay", "Name" },
                values: new object[] { 3, 2, false, "Cujo" });

            migrationBuilder.CreateIndex(
                name: "IX_CoreOne_HostId",
                table: "CoreOne",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreOneS1_HostId",
                table: "CoreOneS1",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreOneS2_HostId",
                table: "CoreOneS2",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreTwo_HostId",
                table: "CoreTwo",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreTwoS1_HostId",
                table: "CoreTwoS1",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreTwoS2_HostId",
                table: "CoreTwoS2",
                column: "HostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoreOneS1");

            migrationBuilder.DropTable(
                name: "CoreOneS2");

            migrationBuilder.DropTable(
                name: "CoreTwoS1");

            migrationBuilder.DropTable(
                name: "CoreTwoS2");

            migrationBuilder.DropTable(
                name: "CoreOne");

            migrationBuilder.DropTable(
                name: "CoreTwo");

            migrationBuilder.DropTable(
                name: "ParentOnes");

            migrationBuilder.DropTable(
                name: "ParentTwos");
        }
    }
}
