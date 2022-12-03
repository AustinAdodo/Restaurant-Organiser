using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_Menu_Organiser.Data.Migrations
{
    public partial class EmployeeSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeActivities", "EmployeeBasicAllowance", "EmployeeBasicSalary", "EmployeeDOB", "EmployeeDepartment", "EmployeeEmail", "EmployeeEmploymentDate", "EmployeeFirstName", "EmployeeIdExtId", "EmployeeImagePath", "EmployeeLGAOfOrigin", "EmployeeLastName", "EmployeeMiddleName", "EmployeeNationality", "EmployeeOtherAllowance", "EmployeePhoneNumber", "EmployeeRemarks", "EmployeeResidence", "EmployeeSex", "EmployeeStateOfOrigin", "EmployeeStatus" },
                values: new object[,]
                {
                    { 1, "Employee Added today 19-06-2016 ", 200000m, 10000000m, new DateTime(1960, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "boss@happycheff.com", new DateTime(2016, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Main", "HappyCheff1906201625", "", "Esan-North-East", "Lady", "Boss", "Nigerian", 1000m, "+23480313201732", null, "Airtel road, Banana Island,Ikoyi,Lagos", "Female", "Edo", "Active" },
                    { 2, "Employee Added today 12-10-2016 ", 30000m, 5000000m, new DateTime(1985, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "austin@happycheff.com", new DateTime(2016, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "HappyCheff1210201650", "", "Esan", "Adodo", "Odia", "Nigerian", 0m, "+23480213240928", null, "Parkers,Banana Island,Ikoyi,Lagos", "Male", "Edo", "Active" },
                    { 3, "Employee Added today 12-10-2016 ", 30000m, 5000000m, new DateTime(1994, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "austin@happycheff.com", new DateTime(2016, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "MJ", "HappyCheff1210201665", "", "Esan-North-East", "Adodo", "Oba", "Nigerian", 0m, "+23480213240929", null, "Parkers,Banana Island,Ikoyi,Lagos", "Female", "Edo", "Active" },
                    { 7, "Employee Added today 12-10-2016 ", 30000m, 1000000m, new DateTime(1990, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Procurement", "smartcheff@happycheff.com", new DateTime(2016, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Happy", "HappyCheff1210201654", "", "", "Cheff", "", "American", 0m, "+23481141571804", null, "1004 Estate,Victoria Island,Lagos", "Male", "", "Active" },
                    { 4, "Employee Added today 12-10-2016 ", 30000m, 1000000m, new DateTime(1990, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Procurement", "smartcheff2@happycheff.com", new DateTime(2016, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Happy", "HappyCheff1210201660", "", "", "Cheff2", "", "American", 0m, "+23481141571805", null, "Osborne forsore,Ikoyi,Lagos", "Male", "", "Active" },
                    { 5, "Employee Added today 12-10-2016 ", 30000m, 1000000m, new DateTime(1990, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Procurement", "smartcheff3@happycheff.com", new DateTime(2016, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Happy", "HappyCheff1210201654", "", "", "Cheff3", "", "American", 0m, "+23481141571805", null, "Parkview,Ikoyi,Lagos", "Male", "", "Active" },
                    { 6, "Employee Added today 12-10-2016 ", 30000m, 1000000m, new DateTime(1990, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Procurement", "smartcheff1@happycheff.com", new DateTime(2016, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Happy", "HappyCheff1210201656", "", "", "Cheff1", "", "American", 0m, "+23481182284455", null, "Parkview,Ikoyi,Lagos", "Male", "", "Active" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

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
    }
}
