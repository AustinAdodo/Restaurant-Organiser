using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_Menu_Organiser.Data.Migrations
{
    public partial class Sales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SumTotal = table.Column<decimal>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    Quantity = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    RestaurantName = table.Column<string>(nullable: true),
                    orderPlacement = table.Column<string>(nullable: true),
                    PaymentType = table.Column<string>(nullable: true),
                    SaleDate = table.Column<DateTime>(nullable: false),
                    SaleTime = table.Column<TimeSpan>(nullable: false),
                    StaffName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "ItemName", "PaymentType", "Price", "Quantity", "RestaurantName", "SaleDate", "SaleTime", "StaffName", "SumTotal", "orderPlacement" },
                values: new object[,]
                {
                    { 10000001, "Nigerian Party Jellof Rice", "Stripe", 2.00m, 2m, "Happy Restaurant", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 0, 0, 0, 0), "Happy Cheff1", 4.00m, "Internal" },
                    { 10000002, "Kimchi", "POS", 3.40m, 2m, "Happy Restaurant", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 0, 0, 0, 0), "Happy Cheff1", 6.80m, "Internal" },
                    { 10000003, "Kimchi", "POS", 2.40m, 4.00m, "Happy Restaurant", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 0, 0, 0, 0), "Happy Cheff1", 9.60m, "Internal" },
                    { 10000004, "Dal Makhani", "POS", 1.50m, 2m, "Happy Restaurant", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 0, 0, 0, 0), "Happy Cheff1", 3.00m, "Internal" },
                    { 10000005, "Sweet & Sour Soup", "Cash", 1.20m, 2m, "Happy Restaurant", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 0, 0, 0, 0), "Happy Cheff1", 2.40m, "Internal" },
                    { 10000006, "Tofu Mushroom", "POS", 5.00m, 1m, "Happy Restaurant", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 0, 0, 0, 0), "Happy Cheff1", 5.000m, "Internal" },
                    { 10000007, "Calamari Fries & Chips", "POS", 1.00m, 6m, "Happy Restaurant", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 0, 0, 0, 0), "Happy Cheff1", 6.00m, "Internal" },
                    { 10000009, "Bimbimbap", "POS", 2.00m, 2m, "Happy Restaurant", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 0, 0, 0, 0), "Happy Cheff1", 4.00m, "Internal" },
                    { 10000010, "Korma", "Cash", 2.50m, 2m, "Happy Restaurant", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 0, 0, 0, 0), "Happy Cheff1", 5.00m, "Internal" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");
        }
    }
}
