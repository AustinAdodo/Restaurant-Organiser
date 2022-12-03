using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_Menu_Organiser.Data.Migrations
{
    public partial class Modify1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryAlias",
                table: "Items",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CountryAlias",
                value: "Nigerian");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CountryAlias",
                value: "Nigerian");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CountryAlias",
                value: "Nigerian");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CountryAlias",
                value: "Nigerian");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "CountryAlias",
                value: "Korean");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                column: "CountryAlias",
                value: "Indian");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                column: "CountryAlias",
                value: "Korean");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                column: "CountryAlias",
                value: "Korean");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                column: "CountryAlias",
                value: "Korean");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                column: "CountryAlias",
                value: "Korean");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                column: "CountryAlias",
                value: "Korean");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CountryAlias", "pictureUrl" },
                values: new object[] { "Indian", "/Food/Korma.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CountryAlias", "pictureUrl" },
                values: new object[] { "Chinese", "/Food/PeckingSoup.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CountryAlias", "pictureUrl" },
                values: new object[] { "Chinese", "/Food/CalamariFriesandChips.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CountryAlias", "pictureUrl" },
                values: new object[] { "Chinese", "/Food/GrilledSalmon.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CountryAlias", "pictureUrl" },
                values: new object[] { "Chinese", "/Food/TofuMushroomSoup.jpg" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ClassificationId", "Country", "CountryAlias", "DateCreated", "DateModified", "ExternalId", "Name", "pictureUrl" },
                values: new object[,]
                {
                    { 17, 10000020, "Italy", "Italian", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ItalyPenne001", "Penne", "/Food/Penne.jpg" },
                    { 23, 10000020, "Italy", "Italian", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ItalyPastaSalad001", "Pasta Salad", "/Food/PastaSalad.jpg" },
                    { 22, 10000020, "Italy", "Italian", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ItalyRavioli001", "Ravioli", "/Food/Ravioli.jpg" },
                    { 21, 10000020, "China", "Chinese", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ChinaChineseFriedRice001", "Chinese Fried Rice", "/Food/ChineseFriedRice.jpg" },
                    { 20, 10000020, "India", "Chinese", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ChinaChickenTikkaMasalas001", "Chicken Tikka Masala", "/Food/ChickenTikkaMasala.jpg" },
                    { 19, 10000020, "India", "Indian", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ChinaPalakPaneer001", "Palak Paneer", "/Food/PalakPaneer.jpg" },
                    { 18, 10000020, "Ghana", "Ghanian", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "GhanaRedRed001", "Red Red", "/Food/RedRed.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000001,
                column: "SaleDate",
                value: new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000002,
                column: "SaleDate",
                value: new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000003,
                column: "SaleDate",
                value: new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000004,
                column: "SaleDate",
                value: new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000005,
                column: "SaleDate",
                value: new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000006,
                column: "SaleDate",
                value: new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000007,
                column: "SaleDate",
                value: new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000009,
                column: "SaleDate",
                value: new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000010,
                column: "SaleDate",
                value: new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DropColumn(
                name: "CountryAlias",
                table: "Items");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                column: "pictureUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                column: "pictureUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                column: "pictureUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                column: "pictureUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                column: "pictureUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000001,
                column: "SaleDate",
                value: new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000002,
                column: "SaleDate",
                value: new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000003,
                column: "SaleDate",
                value: new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000004,
                column: "SaleDate",
                value: new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000005,
                column: "SaleDate",
                value: new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000006,
                column: "SaleDate",
                value: new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000007,
                column: "SaleDate",
                value: new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000009,
                column: "SaleDate",
                value: new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000010,
                column: "SaleDate",
                value: new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
