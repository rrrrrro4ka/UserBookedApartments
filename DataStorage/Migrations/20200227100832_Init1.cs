using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataStorage.Migrations
{
    public partial class Init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    Area = table.Column<double>(nullable: false),
                    Rooms = table.Column<int>(nullable: false),
                    MaxGuets = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(nullable: true),
                    MobilePhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentsBooked",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    DateStartBooked = table.Column<DateTime>(nullable: false),
                    DateEndBooked = table.Column<DateTime>(nullable: false),
                    CountGuest = table.Column<int>(nullable: false),
                    ApartmentsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentsBooked", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApartmentsBooked_Apartments_ApartmentsId",
                        column: x => x.ApartmentsId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApartmentsBooked_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentsBooked_ApartmentsId",
                table: "ApartmentsBooked",
                column: "ApartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentsBooked_UserId",
                table: "ApartmentsBooked",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApartmentsBooked");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
