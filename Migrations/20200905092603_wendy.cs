using Microsoft.EntityFrameworkCore.Migrations;

namespace efcoreGenerics.Migrations
{
    public partial class wendy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HOneSubOne_CoreOne_HostId",
                table: "HOneSubOne");

            migrationBuilder.DropForeignKey(
                name: "FK_HOOneSubTwo_CoreOne_HostId",
                table: "HOOneSubTwo");

            migrationBuilder.DropForeignKey(
                name: "FK_HTwoSubOne_CoreTwo_HostId",
                table: "HTwoSubOne");

            migrationBuilder.DropForeignKey(
                name: "FK_HTwoSubTwo_CoreTwo_HostId",
                table: "HTwoSubTwo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HTwoSubTwo",
                table: "HTwoSubTwo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HTwoSubOne",
                table: "HTwoSubOne");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HOOneSubTwo",
                table: "HOOneSubTwo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HOneSubOne",
                table: "HOneSubOne");

            migrationBuilder.RenameTable(
                name: "HTwoSubTwo",
                newName: "CoreTwoS2");

            migrationBuilder.RenameTable(
                name: "HTwoSubOne",
                newName: "CoreTwoS1");

            migrationBuilder.RenameTable(
                name: "HOOneSubTwo",
                newName: "CoreOneS2");

            migrationBuilder.RenameTable(
                name: "HOneSubOne",
                newName: "CoreOneS1");

            migrationBuilder.RenameIndex(
                name: "IX_HTwoSubTwo_HostId",
                table: "CoreTwoS2",
                newName: "IX_CoreTwoS2_HostId");

            migrationBuilder.RenameIndex(
                name: "IX_HTwoSubOne_HostId",
                table: "CoreTwoS1",
                newName: "IX_CoreTwoS1_HostId");

            migrationBuilder.RenameIndex(
                name: "IX_HOOneSubTwo_HostId",
                table: "CoreOneS2",
                newName: "IX_CoreOneS2_HostId");

            migrationBuilder.RenameIndex(
                name: "IX_HOneSubOne_HostId",
                table: "CoreOneS1",
                newName: "IX_CoreOneS1_HostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoreTwoS2",
                table: "CoreTwoS2",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoreTwoS1",
                table: "CoreTwoS1",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoreOneS2",
                table: "CoreOneS2",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoreOneS1",
                table: "CoreOneS1",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CoreOneS1_CoreOne_HostId",
                table: "CoreOneS1",
                column: "HostId",
                principalTable: "CoreOne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoreOneS2_CoreOne_HostId",
                table: "CoreOneS2",
                column: "HostId",
                principalTable: "CoreOne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoreTwoS1_CoreTwo_HostId",
                table: "CoreTwoS1",
                column: "HostId",
                principalTable: "CoreTwo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoreTwoS2_CoreTwo_HostId",
                table: "CoreTwoS2",
                column: "HostId",
                principalTable: "CoreTwo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoreOneS1_CoreOne_HostId",
                table: "CoreOneS1");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreOneS2_CoreOne_HostId",
                table: "CoreOneS2");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreTwoS1_CoreTwo_HostId",
                table: "CoreTwoS1");

            migrationBuilder.DropForeignKey(
                name: "FK_CoreTwoS2_CoreTwo_HostId",
                table: "CoreTwoS2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoreTwoS2",
                table: "CoreTwoS2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoreTwoS1",
                table: "CoreTwoS1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoreOneS2",
                table: "CoreOneS2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoreOneS1",
                table: "CoreOneS1");

            migrationBuilder.RenameTable(
                name: "CoreTwoS2",
                newName: "HTwoSubTwo");

            migrationBuilder.RenameTable(
                name: "CoreTwoS1",
                newName: "HTwoSubOne");

            migrationBuilder.RenameTable(
                name: "CoreOneS2",
                newName: "HOOneSubTwo");

            migrationBuilder.RenameTable(
                name: "CoreOneS1",
                newName: "HOneSubOne");

            migrationBuilder.RenameIndex(
                name: "IX_CoreTwoS2_HostId",
                table: "HTwoSubTwo",
                newName: "IX_HTwoSubTwo_HostId");

            migrationBuilder.RenameIndex(
                name: "IX_CoreTwoS1_HostId",
                table: "HTwoSubOne",
                newName: "IX_HTwoSubOne_HostId");

            migrationBuilder.RenameIndex(
                name: "IX_CoreOneS2_HostId",
                table: "HOOneSubTwo",
                newName: "IX_HOOneSubTwo_HostId");

            migrationBuilder.RenameIndex(
                name: "IX_CoreOneS1_HostId",
                table: "HOneSubOne",
                newName: "IX_HOneSubOne_HostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HTwoSubTwo",
                table: "HTwoSubTwo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HTwoSubOne",
                table: "HTwoSubOne",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HOOneSubTwo",
                table: "HOOneSubTwo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HOneSubOne",
                table: "HOneSubOne",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HOneSubOne_CoreOne_HostId",
                table: "HOneSubOne",
                column: "HostId",
                principalTable: "CoreOne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HOOneSubTwo_CoreOne_HostId",
                table: "HOOneSubTwo",
                column: "HostId",
                principalTable: "CoreOne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HTwoSubOne_CoreTwo_HostId",
                table: "HTwoSubOne",
                column: "HostId",
                principalTable: "CoreTwo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HTwoSubTwo_CoreTwo_HostId",
                table: "HTwoSubTwo",
                column: "HostId",
                principalTable: "CoreTwo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
