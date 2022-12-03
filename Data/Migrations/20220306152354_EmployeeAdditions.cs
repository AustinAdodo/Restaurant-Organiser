using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_Menu_Organiser.Data.Migrations
{
    public partial class EmployeeAdditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "EmployeeIdExtId",
                value: "HappyCheff1210201659");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "EmployeeEmail", "EmployeeIdExtId", "EmployeeLastName", "EmployeePhoneNumber", "EmployeeResidence" },
                values: new object[] { "smartcheff@happycheff.com", "HappyCheff1210201654", "Cheff", "+23481141571804", "1004 Estate,Victoria Island,Lagos" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "EmployeeEmail", "EmployeeIdExtId", "EmployeeLastName", "EmployeePhoneNumber", "EmployeeResidence" },
                values: new object[] { "smartcheff4@happycheff.com", "HappyCheff1210201670", "Cheff4", "+23481182284455", "Parkview,Ikoyi,Lagos" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeActivities", "EmployeeBasicAllowance", "EmployeeBasicSalary", "EmployeeDOB", "EmployeeDepartment", "EmployeeEmail", "EmployeeEmploymentDate", "EmployeeFirstName", "EmployeeIdExtId", "EmployeeImagePath", "EmployeeLGAOfOrigin", "EmployeeLastName", "EmployeeMiddleName", "EmployeeNationality", "EmployeeOtherAllowance", "EmployeePhoneNumber", "EmployeeRemarks", "EmployeeResidence", "EmployeeSex", "EmployeeStateOfOrigin", "EmployeeStatus" },
                values: new object[,]
                {
                    { 8, "Employee Added today 12-10-2016 ", 30000m, 1000000m, new DateTime(1990, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Procurement", "smartcheff5@happycheff.com", new DateTime(2016, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Happy", "HappyCheff1210201671", "", "", "Cheff5", "", "American", 0m, "+23481182284456", null, "Parkview,Ikoyi,Lagos", "Male", "", "Active" },
                    { 9, "Employee Added today 12-10-2016 ", 30000m, 1000000m, new DateTime(1990, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Procurement", "smartcheff6@happycheff.com", new DateTime(2016, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Happy", "HappyCheff1210201674", "", "", "Cheff6", "", "American", 0m, "+23481182284455", null, "Parkview,Ikoyi,Lagos", "Male", "", "Active" }
                });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000001,
                column: "SaleDate",
                value: new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000002,
                column: "SaleDate",
                value: new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000003,
                column: "SaleDate",
                value: new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000004,
                column: "SaleDate",
                value: new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000005,
                column: "SaleDate",
                value: new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000006,
                column: "SaleDate",
                value: new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000007,
                column: "SaleDate",
                value: new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000009,
                column: "SaleDate",
                value: new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000010,
                column: "SaleDate",
                value: new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "EmployeeIdExtId",
                value: "HappyCheff1210201654");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "EmployeeEmail", "EmployeeIdExtId", "EmployeeLastName", "EmployeePhoneNumber", "EmployeeResidence" },
                values: new object[] { "smartcheff1@happycheff.com", "HappyCheff1210201656", "Cheff1", "+23481182284455", "Parkview,Ikoyi,Lagos" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "EmployeeEmail", "EmployeeIdExtId", "EmployeeLastName", "EmployeePhoneNumber", "EmployeeResidence" },
                values: new object[] { "smartcheff@happycheff.com", "HappyCheff1210201654", "Cheff", "+23481141571804", "1004 Estate,Victoria Island,Lagos" });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000001,
                column: "SaleDate",
                value: new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000002,
                column: "SaleDate",
                value: new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000003,
                column: "SaleDate",
                value: new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000004,
                column: "SaleDate",
                value: new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000005,
                column: "SaleDate",
                value: new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000006,
                column: "SaleDate",
                value: new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000007,
                column: "SaleDate",
                value: new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000009,
                column: "SaleDate",
                value: new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000010,
                column: "SaleDate",
                value: new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
