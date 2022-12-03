using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_Menu_Organiser.Data.Migrations
{
    public partial class OrderStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "ItemName", "MenuStatus", "Orderdate", "Quantity", "Table" },
                values: new object[,]
                {
                    { 101111, "Potato & Chips", "Pending", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "3Plates", 14 },
                    { 101112, "Doro Wot", "Pending", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "1Plates", 14 },
                    { 101113, "Bolognese Sauce & Spaghetti", "Served", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "1Plates", 2 },
                    { 101114, "Fish Curry", "Served", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "6Plates", 9 },
                    { 101115, "Ghana Banku", "Cancelled", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "1Plates", 10 },
                    { 101116, "Lamb Vindaloo", "Pending", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "2Plates", 8 },
                    { 101117, "Pasta Primavera", "Served", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "1Plates", 12 },
                    { 101118, "Cooked Chinese Peppered Lobster", "Served", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "1Plates", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 101111);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 101112);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 101113);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 101114);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 101115);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 101116);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 101117);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 101118);
        }
    }
}
