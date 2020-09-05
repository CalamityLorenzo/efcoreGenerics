using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace efcoreGenerics.Migrations
{
    public partial class Swift : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HostOnes",
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
                    table.PrimaryKey("PK_HostOnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HostTwos",
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
                    table.PrimaryKey("PK_HostTwos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoreOne",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreOne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoreOne_HostOnes_HostId",
                        column: x => x.HostId,
                        principalTable: "HostOnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoreTwo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreTwo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoreTwo_HostTwos_HostId",
                        column: x => x.HostId,
                        principalTable: "HostTwos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HOneSubOne",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostId = table.Column<int>(nullable: false),
                    Numbers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOneSubOne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HOneSubOne_CoreOne_HostId",
                        column: x => x.HostId,
                        principalTable: "CoreOne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HOOneSubTwo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsAOkay = table.Column<bool>(nullable: false),
                    HostId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOOneSubTwo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HOOneSubTwo_CoreOne_HostId",
                        column: x => x.HostId,
                        principalTable: "CoreOne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HTwoSubOne",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostId = table.Column<int>(nullable: false),
                    Numbers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HTwoSubOne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HTwoSubOne_CoreTwo_HostId",
                        column: x => x.HostId,
                        principalTable: "CoreTwo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HTwoSubTwo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsAOkay = table.Column<bool>(nullable: false),
                    HostId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HTwoSubTwo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HTwoSubTwo_CoreTwo_HostId",
                        column: x => x.HostId,
                        principalTable: "CoreTwo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoreOne_HostId",
                table: "CoreOne",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_CoreTwo_HostId",
                table: "CoreTwo",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_HOneSubOne_HostId",
                table: "HOneSubOne",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_HOOneSubTwo_HostId",
                table: "HOOneSubTwo",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_HTwoSubOne_HostId",
                table: "HTwoSubOne",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_HTwoSubTwo_HostId",
                table: "HTwoSubTwo",
                column: "HostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HOneSubOne");

            migrationBuilder.DropTable(
                name: "HOOneSubTwo");

            migrationBuilder.DropTable(
                name: "HTwoSubOne");

            migrationBuilder.DropTable(
                name: "HTwoSubTwo");

            migrationBuilder.DropTable(
                name: "CoreOne");

            migrationBuilder.DropTable(
                name: "CoreTwo");

            migrationBuilder.DropTable(
                name: "HostOnes");

            migrationBuilder.DropTable(
                name: "HostTwos");
        }
    }
}
