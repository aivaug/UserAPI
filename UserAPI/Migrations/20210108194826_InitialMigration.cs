using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Email", "FirstName", "IsDeleted", "LastName", "Phone" },
                values: new object[] { 1, null, new DateTime(2021, 1, 8, 21, 48, 25, 515, DateTimeKind.Local).AddTicks(2787), "Vardenis@Pavardenis.com", "Vardenis", false, "Pavardenis", "86******1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Email", "FirstName", "IsDeleted", "LastName", "Phone" },
                values: new object[] { 2, null, new DateTime(2021, 1, 8, 21, 48, 25, 521, DateTimeKind.Local).AddTicks(1537), "Jonas@Jonaitis.com", "Jonas", false, "Jonaitis", "86******2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Email", "FirstName", "IsDeleted", "LastName", "Phone" },
                values: new object[] { 3, null, new DateTime(2021, 1, 8, 21, 48, 25, 521, DateTimeKind.Local).AddTicks(1866), "Petras@Petraitis.com", "Petras", false, "Petraitis", "86******3" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreatedById",
                table: "Users",
                column: "CreatedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
