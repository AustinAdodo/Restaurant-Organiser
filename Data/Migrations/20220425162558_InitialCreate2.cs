using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_Menu_Organiser.Data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            //migrationBuilder.CreateTable(
            //    name: "Approvals",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        OriginRolePersonel = table.Column<string>(nullable: true),
            //        Name = table.Column<string>(nullable: true),
            //        Time = table.Column<string>(nullable: true),
            //        Date = table.Column<string>(nullable: true),
            //        ApprovalType = table.Column<string>(nullable: true),
            //        status = table.Column<string>(nullable: true),
            //        OriginRole = table.Column<string>(nullable: true),
            //        TargetRole = table.Column<string>(nullable: true),
            //        TargetRolePersonel = table.Column<string>(nullable: true),
            //        Parameters = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Approvals", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "DisposableEmployeesData",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeStatus = table.Column<string>(nullable: false),
                    EmployeeLastName = table.Column<string>(nullable: false),
                    EmployeeBasicSalary = table.Column<decimal>(nullable: false),
                    EmployeeBasicAllowance = table.Column<decimal>(nullable: false),
                    EmployeeOtherAllowance = table.Column<decimal>(nullable: false),
                    EmployeeFirstName = table.Column<string>(nullable: false),
                    EmployeeMiddleName = table.Column<string>(nullable: true),
                    EmployeeImagePath = table.Column<string>(nullable: true),
                    EmployeeIdExtId = table.Column<string>(nullable: false),
                    EmployeeDOB = table.Column<DateTime>(nullable: false),
                    EmployeeEmploymentDate = table.Column<DateTime>(nullable: false),
                    EmployeeSex = table.Column<string>(nullable: false),
                    EmployeeDepartment = table.Column<string>(nullable: false),
                    EmployeePhoneNumber = table.Column<string>(nullable: false),
                    EmployeeEmail = table.Column<string>(nullable: true),
                    EmployeeResidence = table.Column<string>(nullable: false),
                    EmployeeNationality = table.Column<string>(nullable: false),
                    EmployeeStateOfOrigin = table.Column<string>(nullable: false),
                    EmployeeLGAOfOrigin = table.Column<string>(nullable: false),
                    EmployeeActivities = table.Column<string>(maxLength: 50000, nullable: false),
                    EmployeeRemarks = table.Column<string>(maxLength: 50000, nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    TimeAdded = table.Column<TimeSpan>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    LocalReference = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisposableEmployeesData", x => x.EmployeeId);
                });

            //migrationBuilder.CreateTable(
            //    name: "Notifications",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        NameHeader = table.Column<string>(nullable: true),
            //        Type = table.Column<string>(nullable: true),
            //        Body = table.Column<string>(nullable: true),
            //        Status = table.Column<string>(nullable: true),
            //        ConsumerId = table.Column<string>(nullable: true),
            //        Department = table.Column<string>(nullable: true),
            //        DateandTime = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Notifications", x => x.Id);
            //    });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000001,
                column: "SaleDate",
                value: new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000002,
                column: "SaleDate",
                value: new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000003,
                column: "SaleDate",
                value: new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000004,
                column: "SaleDate",
                value: new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000005,
                column: "SaleDate",
                value: new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000006,
                column: "SaleDate",
                value: new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000007,
                column: "SaleDate",
                value: new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000009,
                column: "SaleDate",
                value: new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 10000010,
                column: "SaleDate",
                value: new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Approvals");

            migrationBuilder.DropTable(
                name: "DisposableEmployeesData");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

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
    }
}
