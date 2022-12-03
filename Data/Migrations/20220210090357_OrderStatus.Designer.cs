﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant_Menu_Organiser.Data;

namespace Restaurant_Menu_Organiser.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220210090357_OrderStatus")]
    partial class OrderStatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Restaurant_Menu_Organiser.Models.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassificationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryClassification")
                        .HasColumnType("int");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Restaurant_Menu_Organiser.Models.Employees.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeActivities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<decimal>("EmployeeBasicAllowance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("EmployeeBasicSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("EmployeeDOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeDepartment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EmployeeEmploymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeIdExtId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLGAOfOrigin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeMiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeNationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("EmployeeOtherAllowance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("EmployeePhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeRemarks")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<string>("EmployeeResidence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeSex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeStateOfOrigin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Restaurant_Menu_Organiser.Models.Items.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassificationId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClassificationId = 1000001,
                            Country = "Nigeria",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "NaijaJellof001",
                            Name = "Nigerian Party Jellof Rice"
                        },
                        new
                        {
                            Id = 2,
                            ClassificationId = 1000001,
                            Country = "Nigeria",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "NaijaEba&Egusi001",
                            Name = "Eba & Egusi"
                        },
                        new
                        {
                            Id = 3,
                            ClassificationId = 1000001,
                            Country = "Nigeria",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "NaijaPoundedYam&Egusii001",
                            Name = "Pounded Yam & Egusi"
                        },
                        new
                        {
                            Id = 4,
                            ClassificationId = 1000001,
                            Country = "Nigeria",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "NaijaEba&Egusi001",
                            Name = "Potato & Chips"
                        },
                        new
                        {
                            Id = 5,
                            ClassificationId = 1000001,
                            Country = "South-Korea",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "KoreanBeefBulgogi001",
                            Name = "Beef Bulgogi",
                            pictureUrl = "/Food/BeefBulgogi.jpg"
                        },
                        new
                        {
                            Id = 6,
                            ClassificationId = 1000001,
                            Country = "India",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "KoreanBeefBulgogi001",
                            Name = "Dal Makhani"
                        },
                        new
                        {
                            Id = 7,
                            ClassificationId = 1000001,
                            Country = "South-Korea",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "KoreanBeefBulgogi001",
                            Name = "Donburi",
                            pictureUrl = "/Food/Donburi.jpg"
                        },
                        new
                        {
                            Id = 8,
                            ClassificationId = 1000001,
                            Country = "South-Korea",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "KoreanBeefBulgogi001",
                            Name = "Samgyeopsal",
                            pictureUrl = "/Food/Samgyeopsal.jpg"
                        },
                        new
                        {
                            Id = 9,
                            ClassificationId = 1000001,
                            Country = "South-Korea",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "KoreanBeefBulgogi001",
                            Name = "Sweet & Sour Soup",
                            pictureUrl = "/Food/SweetSourSoup.jpg"
                        },
                        new
                        {
                            Id = 10,
                            ClassificationId = 1000001,
                            Country = "South-Korea",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "KoreanKimchi001",
                            Name = "Kimchi",
                            pictureUrl = "/Food/Kimchi.jpg"
                        },
                        new
                        {
                            Id = 11,
                            ClassificationId = 10000010,
                            Country = "South-Korea",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "KoreanBeefBulgogi001",
                            Name = "Bimbimbap",
                            pictureUrl = "/Food/Bibimbap.jpg"
                        },
                        new
                        {
                            Id = 12,
                            ClassificationId = 10000011,
                            Country = "India",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "IndiaKorma001",
                            Name = "Korma"
                        },
                        new
                        {
                            Id = 13,
                            ClassificationId = 10000020,
                            Country = "China",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "ChinaPeckingSoup001",
                            Name = "Pecking Soup"
                        },
                        new
                        {
                            Id = 14,
                            ClassificationId = 10000020,
                            Country = "China",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "ChinaCalamariFries&Chips001",
                            Name = "Calamari Fries & Chips"
                        },
                        new
                        {
                            Id = 15,
                            ClassificationId = 10000020,
                            Country = "China",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "ChinaGrilledSalmon001",
                            Name = "Grilled Salmon"
                        },
                        new
                        {
                            Id = 16,
                            ClassificationId = 10000020,
                            Country = "China",
                            DateCreated = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExternalId = "ChinaTofuMushrooms001",
                            Name = "Tofu Mushroom"
                        });
                });

            modelBuilder.Entity("Restaurant_Menu_Organiser.Models.OrderStatus", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Orderdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Table")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 101111,
                            ItemName = "Potato & Chips",
                            MenuStatus = "Pending",
                            Orderdate = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = "3Plates",
                            Table = 14
                        },
                        new
                        {
                            OrderId = 101112,
                            ItemName = "Doro Wot",
                            MenuStatus = "Pending",
                            Orderdate = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = "1Plates",
                            Table = 14
                        },
                        new
                        {
                            OrderId = 101113,
                            ItemName = "Bolognese Sauce & Spaghetti",
                            MenuStatus = "Served",
                            Orderdate = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = "1Plates",
                            Table = 2
                        },
                        new
                        {
                            OrderId = 101114,
                            ItemName = "Fish Curry",
                            MenuStatus = "Served",
                            Orderdate = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = "6Plates",
                            Table = 9
                        },
                        new
                        {
                            OrderId = 101115,
                            ItemName = "Ghana Banku",
                            MenuStatus = "Cancelled",
                            Orderdate = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = "1Plates",
                            Table = 10
                        },
                        new
                        {
                            OrderId = 101116,
                            ItemName = "Lamb Vindaloo",
                            MenuStatus = "Pending",
                            Orderdate = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = "2Plates",
                            Table = 8
                        },
                        new
                        {
                            OrderId = 101117,
                            ItemName = "Pasta Primavera",
                            MenuStatus = "Served",
                            Orderdate = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = "1Plates",
                            Table = 12
                        },
                        new
                        {
                            OrderId = 101118,
                            ItemName = "Cooked Chinese Peppered Lobster",
                            MenuStatus = "Served",
                            Orderdate = new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = "1Plates",
                            Table = 5
                        });
                });

            modelBuilder.Entity("Restaurant_Menu_Organiser.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SaleDateandTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StaffNameEmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("SumTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("orderPlacement")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StaffNameEmployeeId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restaurant_Menu_Organiser.Models.Sale", b =>
                {
                    b.HasOne("Restaurant_Menu_Organiser.Models.Employees.Employee", "StaffName")
                        .WithMany()
                        .HasForeignKey("StaffNameEmployeeId");
                });
#pragma warning restore 612, 618
        }
    }
}
