using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceptionProject.Migrations
{
    public partial class OnDeleteBehaviorChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GuestReservations_Guests_GuestId",
                table: "GuestReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_GuestReservations_Reservations_ReservationId",
                table: "GuestReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomInventories_Items_InventoryItemId",
                table: "RoomInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomInventories_Rooms_RoomId",
                table: "RoomInventories");

            migrationBuilder.AddForeignKey(
                name: "FK_GuestReservations_Guests_GuestId",
                table: "GuestReservations",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GuestReservations_Reservations_ReservationId",
                table: "GuestReservations",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomInventories_Items_InventoryItemId",
                table: "RoomInventories",
                column: "InventoryItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomInventories_Rooms_RoomId",
                table: "RoomInventories",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GuestReservations_Guests_GuestId",
                table: "GuestReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_GuestReservations_Reservations_ReservationId",
                table: "GuestReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomInventories_Items_InventoryItemId",
                table: "RoomInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomInventories_Rooms_RoomId",
                table: "RoomInventories");

            migrationBuilder.AddForeignKey(
                name: "FK_GuestReservations_Guests_GuestId",
                table: "GuestReservations",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GuestReservations_Reservations_ReservationId",
                table: "GuestReservations",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomInventories_Items_InventoryItemId",
                table: "RoomInventories",
                column: "InventoryItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomInventories_Rooms_RoomId",
                table: "RoomInventories",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
