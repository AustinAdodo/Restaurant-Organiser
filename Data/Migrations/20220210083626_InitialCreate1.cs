using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_Menu_Organiser.Data.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "AspNetRoles",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(nullable: false),
            //        Name = table.Column<string>(maxLength: 256, nullable: true),
            //        NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
            //        ConcurrencyStamp = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUsers",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(nullable: false),
            //        UserName = table.Column<string>(maxLength: 256, nullable: true),
            //        NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
            //        Email = table.Column<string>(maxLength: 256, nullable: true),
            //        NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
            //        EmailConfirmed = table.Column<bool>(nullable: false),
            //        PasswordHash = table.Column<string>(nullable: true),
            //        SecurityStamp = table.Column<string>(nullable: true),
            //        ConcurrencyStamp = table.Column<string>(nullable: true),
            //        PhoneNumber = table.Column<string>(nullable: true),
            //        PhoneNumberConfirmed = table.Column<bool>(nullable: false),
            //        TwoFactorEnabled = table.Column<bool>(nullable: false),
            //        LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
            //        LockoutEnabled = table.Column<bool>(nullable: false),
            //        AccessFailedCount = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUsers", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(nullable: true),
                    CountryClassification = table.Column<int>(nullable: false),
                    ClassificationId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
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
                    EmployeeRemarks = table.Column<string>(maxLength: 50000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ExternalId = table.Column<string>(nullable: false),
                    pictureUrl = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    ClassificationId = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Table = table.Column<int>(nullable: false),
                    MenuStatus = table.Column<string>(nullable: true),
                    ItemName = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    Orderdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            //migrationBuilder.CreateTable(
            //    name: "AspNetRoleClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RoleId = table.Column<string>(nullable: false),
            //        ClaimType = table.Column<string>(nullable: true),
            //        ClaimValue = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<string>(nullable: false),
            //        ClaimType = table.Column<string>(nullable: true),
            //        ClaimValue = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserClaims_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserLogins",
            //    columns: table => new
            //    {
            //        LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
            //        ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
            //        ProviderDisplayName = table.Column<string>(nullable: true),
            //        UserId = table.Column<string>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserLogins_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserRoles",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(nullable: false),
            //        RoleId = table.Column<string>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserTokens",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(nullable: false),
            //        LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
            //        Name = table.Column<string>(maxLength: 128, nullable: false),
            //        Value = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserTokens_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SumTotal = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    RestaurantName = table.Column<string>(nullable: true),
                    orderPlacement = table.Column<string>(nullable: true),
                    PaymentType = table.Column<string>(nullable: true),
                    SaleDateandTime = table.Column<DateTime>(nullable: false),
                    StaffNameEmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Employees_StaffNameEmployeeId",
                        column: x => x.StaffNameEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ClassificationId", "Country", "DateCreated", "DateModified", "ExternalId", "Name", "pictureUrl" },
                values: new object[,]
                {
                    { 1, 1000001, "Nigeria", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "NaijaJellof001", "Nigerian Party Jellof Rice", null },
                    { 2, 1000001, "Nigeria", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "NaijaEba&Egusi001", "Eba & Egusi", null },
                    { 3, 1000001, "Nigeria", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "NaijaPoundedYam&Egusii001", "Pounded Yam & Egusi", null },
                    { 4, 1000001, "Nigeria", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "NaijaEba&Egusi001", "Potato & Chips", null },
                    { 5, 1000001, "South-Korea", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "KoreanBeefBulgogi001", "Beef Bulgogi", "/Food/BeefBulgogi.jpg" },
                    { 6, 1000001, "India", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "KoreanBeefBulgogi001", "Dal Makhani", "/Food/DalMakhani.jpg" },
                    { 7, 1000001, "South-Korea", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "KoreanBeefBulgogi001", "Donburi", "/Food/Donburi.jpg" },
                    { 8, 1000001, "South-Korea", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "KoreanBeefBulgogi001", "Samgyeopsal", "/Food/Samgyeopsal.jpg" },
                    { 9, 1000001, "South-Korea", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "KoreanBeefBulgogi001", "Sweet & Sour Soup", "/Food/SweetSourSoup.jpg" },
                    { 10, 1000001, "South-Korea", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "KoreanKimchi001", "Kimchi", "/Food/Kimchi.jpg" },
                    { 11, 10000010, "South-Korea", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "KoreanBeefBulgogi001", "Bimbimbap", "/Food/Bibimbap.jpg" },
                    { 12, 10000011, "India", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "IndiaKorma001", "Korma", null },
                    { 13, 10000020, "China", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ChinaPeckingSoup001", "Pecking Soup", null },
                    { 14, 10000020, "China", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ChinaCalamariFries&Chips001", "Calamari Fries & Chips", null },
                    { 15, 10000020, "China", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ChinaGrilledSalmon001", "Grilled Salmon", null },
                    { 16, 10000020, "China", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ChinaTofuMushrooms001", "Tofu Mushroom", null }
                });

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetRoleClaims_RoleId",
            //    table: "AspNetRoleClaims",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "RoleNameIndex",
            //    table: "AspNetRoles",
            //    column: "NormalizedName",
            //    unique: true,
            //    filter: "[NormalizedName] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserClaims_UserId",
            //    table: "AspNetUserClaims",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserLogins_UserId",
            //    table: "AspNetUserLogins",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserRoles_RoleId",
            //    table: "AspNetUserRoles",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "EmailIndex",
            //    table: "AspNetUsers",
            //    column: "NormalizedEmail");

            //migrationBuilder.CreateIndex(
            //    name: "UserNameIndex",
            //    table: "AspNetUsers",
            //    column: "NormalizedUserName",
            //    unique: true,
            //    filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_StaffNameEmployeeId",
                table: "Sales",
                column: "StaffNameEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
