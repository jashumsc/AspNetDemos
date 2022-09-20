using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignThurs.Migrations
{
    public partial class AlteredBikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BikePicUrl",
                table: "Bikes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BikePicUrl",
                table: "Bikes");
        }
    }
}
