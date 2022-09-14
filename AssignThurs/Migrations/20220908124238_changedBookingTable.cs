using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignThurs.Migrations
{
    public partial class changedBookingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Bookings");

            migrationBuilder.AddColumn<DateTime>(
                name: "JoinedOn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JoinedOn",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "Date",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
