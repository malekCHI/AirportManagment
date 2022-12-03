using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class service : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_MyPlanes_planeId",
                table: "Flights");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_MyPlanes_planeId",
                table: "Flights",
                column: "planeId",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_MyPlanes_planeId",
                table: "Flights");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_MyPlanes_planeId",
                table: "Flights",
                column: "planeId",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
