using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class anno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_planeId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Planes_Planes_PlaneId1",
                table: "Planes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Planes",
                table: "Planes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "Planes",
                newName: "MyPlanes");

            migrationBuilder.RenameTable(
                name: "FlightPassenger",
                newName: "Reservation");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Passengers",
                newName: "passlastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Passengers",
                newName: "passfirstname");

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Passengers",
                newName: "IsTravller");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "MyPlanes",
                newName: "PlaneCapacity");

            migrationBuilder.RenameIndex(
                name: "IX_Planes_PlaneId1",
                table: "MyPlanes",
                newName: "IX_MyPlanes_PlaneId1");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_PassengersId",
                table: "Reservation",
                newName: "IX_Reservation_PassengersId");

            migrationBuilder.AlterColumn<string>(
                name: "passfirstname",
                table: "Passengers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyPlanes",
                table: "MyPlanes",
                column: "PlaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                columns: new[] { "FlightsFlightId", "PassengersId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_MyPlanes_planeId",
                table: "Flights",
                column: "planeId",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyPlanes_MyPlanes_PlaneId1",
                table: "MyPlanes",
                column: "PlaneId1",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Flights_FlightsFlightId",
                table: "Reservation",
                column: "FlightsFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Passengers_PassengersId",
                table: "Reservation",
                column: "PassengersId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_MyPlanes_planeId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_MyPlanes_MyPlanes_PlaneId1",
                table: "MyPlanes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Flights_FlightsFlightId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Passengers_PassengersId",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyPlanes",
                table: "MyPlanes");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "MyPlanes",
                newName: "Planes");

            migrationBuilder.RenameColumn(
                name: "passlastname",
                table: "Passengers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "passfirstname",
                table: "Passengers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "IsTravller",
                table: "Passengers",
                newName: "Discriminator");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_PassengersId",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_PassengersId");

            migrationBuilder.RenameColumn(
                name: "PlaneCapacity",
                table: "Planes",
                newName: "Capacity");

            migrationBuilder.RenameIndex(
                name: "IX_MyPlanes_PlaneId1",
                table: "Planes",
                newName: "IX_Planes_PlaneId1");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Passengers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightsFlightId", "PassengersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Planes",
                table: "Planes",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsFlightId",
                table: "FlightPassenger",
                column: "FlightsFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersId",
                table: "FlightPassenger",
                column: "PassengersId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_planeId",
                table: "Flights",
                column: "planeId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_Planes_PlaneId1",
                table: "Planes",
                column: "PlaneId1",
                principalTable: "Planes",
                principalColumn: "PlaneId");
        }
    }
}
