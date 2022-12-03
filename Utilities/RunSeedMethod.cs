using Microsoft.EntityFrameworkCore;
using Restaurant_Menu_Organiser.Models;
using Restaurant_Menu_Organiser.Models.Employees;
using Restaurant_Menu_Organiser.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Utilities
{
    public static class RunSeedMethod
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Item>(e =>{ e.HasKey(m => m.ExternalId).HasName("ExtId");
            modelBuilder.Entity<Employee>().HasData(
                 new Employee
                 {
                     EmployeeEmail = "boss@happycheff.com",
                     EmployeeStatus = "Active",
                     EmployeeFirstName = "Main",
                     EmployeeMiddleName = "Boss",
                     EmployeeLastName = "Lady",
                     EmployeeBasicSalary = 10000000,
                     EmployeeBasicAllowance = 200000,
                     EmployeeOtherAllowance = 1000,
                     EmployeeDepartment = "Admin",
                     EmployeeSex = "Female",
                     EmployeeDOB = DateTime.Parse("25-12-1960"),
                     EmployeeId = 1,
                     EmployeeIdExtId = "HappyCheff1906201625",
                     EmployeeNationality = "Nigerian",
                     EmployeeStateOfOrigin = "Edo",
                     EmployeeLGAOfOrigin = "Esan-North-East",
                     EmployeeImagePath = "",
                     EmployeeResidence = "Airtel road, Banana Island,Ikoyi,Lagos",
                     EmployeeEmploymentDate = DateTime.Parse("19-06-2016"),
                     EmployeePhoneNumber = "+23480313201732",
                     EmployeeActivities = "Employee Added today 19-06-2016 ",
                 },
                 new Employee
                 {
                     EmployeeEmail = "austin@happycheff.com",
                     EmployeeStatus = "Active",
                     EmployeeFirstName = "Austin",
                     EmployeeMiddleName = "Odia",
                     EmployeeLastName = "Adodo",
                     EmployeeBasicSalary = 5000000,
                     EmployeeBasicAllowance = 30000,
                     EmployeeOtherAllowance = 0,
                     EmployeeDepartment = "IT",
                     EmployeeSex = "Male",
                     EmployeeDOB = DateTime.Parse("12-08-1985"),
                     EmployeeId = 2,
                     EmployeeIdExtId = "HappyCheff1210201650",
                     EmployeeNationality = "Nigerian",
                     EmployeeStateOfOrigin = "Edo",
                     EmployeeLGAOfOrigin = "Esan",
                     EmployeeImagePath = "",
                     EmployeeResidence = "Parkers,Banana Island,Ikoyi,Lagos",
                     EmployeeEmploymentDate = DateTime.Parse("12-10-2016"),
                     EmployeePhoneNumber = "+23480213240928",
                     EmployeeActivities = "Employee Added today 12-10-2016 ",
                 },
                 new Employee
                 {
                     EmployeeEmail = "austin@happycheff.com",
                     EmployeeStatus = "Active",
                     EmployeeFirstName = "MJ",
                     EmployeeMiddleName = "Oba",
                     EmployeeLastName = "Adodo",
                     EmployeeBasicSalary = 5000000,
                     EmployeeBasicAllowance = 30000,
                     EmployeeOtherAllowance = 0,
                     EmployeeDepartment = "IT",
                     EmployeeSex = "Female",
                     EmployeeDOB = DateTime.Parse("28-05-1994"),
                     EmployeeId = 3,
                     EmployeeIdExtId = "HappyCheff1210201665",
                     EmployeeNationality = "Nigerian",
                     EmployeeStateOfOrigin = "Edo",
                     EmployeeLGAOfOrigin = "Esan-North-East",
                     EmployeeImagePath = "",
                     EmployeeResidence = "Parkers,Banana Island,Ikoyi,Lagos",
                     EmployeeEmploymentDate = DateTime.Parse("12-10-2016"),
                     EmployeePhoneNumber = "+23480213240929",
                     EmployeeActivities = "Employee Added today 12-10-2016 ",
                 },
                 new Employee
                 {
                     EmployeeEmail = "smartcheff2@happycheff.com",
                     EmployeeStatus = "Active",
                     EmployeeFirstName = "Happy",
                     EmployeeMiddleName = "",
                     EmployeeLastName = "Cheff2",
                     EmployeeBasicSalary = 1000000,
                     EmployeeBasicAllowance = 30000,
                     EmployeeOtherAllowance = 0,
                     EmployeeDepartment = "Procurement",
                     EmployeeSex = "Male",
                     EmployeeDOB = DateTime.Parse("06-01-1990"),
                     EmployeeId = 4,
                     EmployeeIdExtId = "HappyCheff1210201660",
                     EmployeeNationality = "American",
                     EmployeeStateOfOrigin = "",
                     EmployeeLGAOfOrigin = "",
                     EmployeeImagePath = "",
                     EmployeeResidence = "Osborne forsore,Ikoyi,Lagos",
                     EmployeeEmploymentDate = DateTime.Parse("12-10-2016"),
                     EmployeePhoneNumber = "+23481141571805",
                     EmployeeActivities = "Employee Added today 12-10-2016 ",
                 },
                 new Employee
                 {
                     EmployeeEmail = "smartcheff3@happycheff.com",
                     EmployeeStatus = "Active",
                     EmployeeFirstName = "Happy",
                     EmployeeMiddleName = "",
                     EmployeeLastName = "Cheff3",
                     EmployeeBasicSalary = 1000000,
                     EmployeeBasicAllowance = 30000,
                     EmployeeOtherAllowance = 0,
                     EmployeeDepartment = "Procurement",
                     EmployeeSex = "Male",
                     EmployeeDOB = DateTime.Parse("06-01-1990"),
                     EmployeeId = 5,
                     EmployeeIdExtId = "HappyCheff1210201659",
                     EmployeeNationality = "American",
                     EmployeeStateOfOrigin = "",
                     EmployeeLGAOfOrigin = "",
                     EmployeeImagePath = "",
                     EmployeeResidence = "Parkview,Ikoyi,Lagos",
                     EmployeeEmploymentDate = DateTime.Parse("12-10-2016"),
                     EmployeePhoneNumber = "+23481141571805",
                     EmployeeActivities = "Employee Added today 12-10-2016 ",
                 },
                 new Employee
                 {
                     EmployeeEmail = "smartcheff@happycheff.com",
                     EmployeeStatus = "Active",
                     EmployeeFirstName = "Happy",
                     EmployeeMiddleName = "",
                     EmployeeLastName = "Cheff",
                     EmployeeBasicSalary = 1000000,
                     EmployeeBasicAllowance = 30000,
                     EmployeeOtherAllowance = 0,
                     EmployeeDepartment = "Procurement",
                     EmployeeSex = "Male",
                     EmployeeDOB = DateTime.Parse("06-01-1990"),
                     EmployeeId = 6,
                     EmployeeIdExtId = "HappyCheff1210201654",
                     EmployeeNationality = "American",
                     EmployeeStateOfOrigin = "",
                     EmployeeLGAOfOrigin = "",
                     EmployeeImagePath = "",
                     EmployeeResidence = "1004 Estate,Victoria Island,Lagos",
                     EmployeeEmploymentDate = DateTime.Parse("12-10-2016"),
                     EmployeePhoneNumber = "+23481141571804",
                     EmployeeActivities = "Employee Added today 12-10-2016 ",
                 },
                 new Employee
                 {
                     EmployeeEmail = "smartcheff4@happycheff.com",
                     EmployeeStatus = "Active",
                     EmployeeFirstName = "Happy",
                     EmployeeMiddleName = "",
                     EmployeeLastName = "Cheff4",
                     EmployeeBasicSalary = 1000000,
                     EmployeeBasicAllowance = 30000,
                     EmployeeOtherAllowance = 0,
                     EmployeeDepartment = "Procurement",
                     EmployeeSex = "Male",
                     EmployeeDOB = DateTime.Parse("06-01-1990"),
                     EmployeeId = 7,
                     EmployeeIdExtId = "HappyCheff1210201670",
                     EmployeeNationality = "American",
                     EmployeeStateOfOrigin = "",
                     EmployeeLGAOfOrigin = "",
                     EmployeeImagePath = "",
                     EmployeeResidence = "Parkview,Ikoyi,Lagos",
                     EmployeeEmploymentDate = DateTime.Parse("12-10-2016"),
                     EmployeePhoneNumber = "+23481182284455",
                     EmployeeActivities = "Employee Added today 12-10-2016 ",
                 },
                 new Employee
                 {
                     EmployeeEmail = "smartcheff5@happycheff.com",
                     EmployeeStatus = "Active",
                     EmployeeFirstName = "Happy",
                     EmployeeMiddleName = "",
                     EmployeeLastName = "Cheff5",
                     EmployeeBasicSalary = 1000000,
                     EmployeeBasicAllowance = 30000,
                     EmployeeOtherAllowance = 0,
                     EmployeeDepartment = "Procurement",
                     EmployeeSex = "Male",
                     EmployeeDOB = DateTime.Parse("06-01-1990"),
                     EmployeeId = 8,
                     EmployeeIdExtId = "HappyCheff1210201671",
                     EmployeeNationality = "American",
                     EmployeeStateOfOrigin = "",
                     EmployeeLGAOfOrigin = "",
                     EmployeeImagePath = "",
                     EmployeeResidence = "Parkview,Ikoyi,Lagos",
                     EmployeeEmploymentDate = DateTime.Parse("12-10-2016"),
                     EmployeePhoneNumber = "+23481182284456",
                     EmployeeActivities = "Employee Added today 12-10-2016 ",
                 },
                 new Employee
                 {
                     EmployeeEmail = "smartcheff6@happycheff.com",
                     EmployeeStatus = "Active",
                     EmployeeFirstName = "Happy",
                     EmployeeMiddleName = "",
                     EmployeeLastName = "Cheff6",
                     EmployeeBasicSalary = 1000000,
                     EmployeeBasicAllowance = 30000,
                     EmployeeOtherAllowance = 0,
                     EmployeeDepartment = "Procurement",
                     EmployeeSex = "Male",
                     EmployeeDOB = DateTime.Parse("06-01-1990"),
                     EmployeeId = 9,
                     EmployeeIdExtId = "HappyCheff1210201674",
                     EmployeeNationality = "American",
                     EmployeeStateOfOrigin = "",
                     EmployeeLGAOfOrigin = "",
                     EmployeeImagePath = "",
                     EmployeeResidence = "Parkview,Ikoyi,Lagos",
                     EmployeeEmploymentDate = DateTime.Parse("12-10-2016"),
                     EmployeePhoneNumber = "+23481182284455",
                     EmployeeActivities = "Employee Added today 12-10-2016 ",
                 }
                );
            modelBuilder.Entity<Item>().HasData(            //});
        new Item
        {
            Id = 1,
            Name = "Nigerian Party Jellof Rice",
            Country = "Nigeria",
            CountryAlias = "Nigerian",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 1000001,
            ExternalId = "NaijaJellof001",
        },
        new Item
        {
            Id = 2,
            Name = "Eba & Egusi",
            Country = "Nigeria",
            CountryAlias = "Nigerian",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 1000001,
            ExternalId = "NaijaEba&Egusi001",
        },
        new Item
        {
            Id = 3,
            Name = "Pounded Yam & Egusi",
            Country = "Nigeria",
            CountryAlias = "Nigerian",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 1000001,
            ExternalId = "NaijaPoundedYam&Egusii001",
        },
        new Item
        {
            Id = 4,
            Name = "Potato & Chips",
            Country = "Nigeria",
            CountryAlias = "Nigerian",
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 1000001,
            ExternalId = "NaijaEba&Egusi001",
        },
        new Item
        {
            Id = 5,
            pictureUrl = "/Food/BeefBulgogi.jpg",
            Name = "Beef Bulgogi",
            Country = "South-Korea",
            CountryAlias = "Korean",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 1000001,
            ExternalId = "KoreanBeefBulgogi001",
        },
        new Item
        {
            Id = 6,
            Name = "Dal Makhani",
            Country = "India",
            CountryAlias = "Indian",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 1000001,
            ExternalId = "KoreanBeefBulgogi001",
        },
        new Item
        {
            Id = 7,
            pictureUrl = "/Food/Donburi.jpg",
            Name = "Donburi",
            Country = "South-Korea",
            CountryAlias = "Korean",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 1000001,
            ExternalId = "KoreanBeefBulgogi001",
        },
        new Item
        {
            Id = 8,
            pictureUrl = "/Food/Samgyeopsal.jpg",
            Name = "Samgyeopsal",
            Country = "South-Korea",
            CountryAlias = "Korean",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 1000001,
            ExternalId = "KoreanBeefBulgogi001",
        },
        new Item
        {
            Id = 9,
            pictureUrl = "/Food/SweetSourSoup.jpg",
            Name = "Sweet & Sour Soup",
            Country = "South-Korea",
            CountryAlias = "Korean",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 1000001,
            ExternalId = "KoreanBeefBulgogi001",
        },
        new Item
        {
            Id = 10,
            pictureUrl = "/Food/Kimchi.jpg",
            Name = "Kimchi",
            Country = "South-Korea",
            CountryAlias = "Korean",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 1000001,
            ExternalId = "KoreanKimchi001",
        },
        new Item
        {
            Id = 11,
            pictureUrl = "/Food/Bibimbap.jpg",
            Name = "Bimbimbap",
            Country = "South-Korea",
            CountryAlias = "Korean",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 10000010,
            ExternalId = "KoreanBeefBulgogi001",
        },
        new Item
        {
            Id = 12,
            Name = "Korma",
            pictureUrl = "/Food/Korma.jpg",
            Country = "India",
            CountryAlias = "Indian",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 10000011,
            ExternalId = "IndiaKorma001",
        },
        new Item
        {
            Id = 13,
            Name = "Pecking Soup",
            pictureUrl = "/Food/PeckingSoup.jpg",
            Country = "China",
            CountryAlias = "Chinese",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 10000020,
            ExternalId = "ChinaPeckingSoup001",
        },
        new Item
        {
            Id = 14,
            Name = "Calamari Fries & Chips",
            pictureUrl = "/Food/CalamariFriesandChips.jpg",
            Country = "China",
            CountryAlias = "Chinese",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 10000020,
            ExternalId = "ChinaCalamariFries&Chips001",
        },
        new Item
        {
            Id = 15,
            Name = "Grilled Salmon",
            pictureUrl = "/Food/GrilledSalmon.jpg",
            Country = "China",
            CountryAlias = "Chinese",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 10000020,
            ExternalId = "ChinaGrilledSalmon001",
        },
        new Item
        {
            Id = 16,
            Name = "Tofu Mushroom",
            pictureUrl = "/Food/TofuMushroomSoup.jpg",
            Country = "China",
            CountryAlias = "Chinese",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 10000020,
            ExternalId = "ChinaTofuMushrooms001",
        },
        new Item
        {
            Id = 17,
            Name = "Penne",
            pictureUrl = "/Food/Penne.jpg",
            Country = "Italy",
            CountryAlias = "Italian",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 10000020,
            ExternalId = "ItalyPenne001",
        },
        new Item
        {
            Id = 18,
            Name = "Red Red",
            pictureUrl = "/Food/RedRed.jpg",
            Country = "Ghana",
            CountryAlias = "Ghanian",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 10000020,
            ExternalId = "GhanaRedRed001",
        },
        new Item
        {
            Id = 19,
            Name = "Palak Paneer",
            Country = "India",
            pictureUrl = "/Food/PalakPaneer.jpg",
            CountryAlias = "Indian",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 10000020,
            ExternalId = "ChinaPalakPaneer001",
        },
        new Item
        {
            Id = 20,
            Name = "Chicken Tikka Masala",
            pictureUrl = "/Food/ChickenTikkaMasala.jpg",
            Country = "India",
            CountryAlias = "Chinese",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 10000020,
            ExternalId = "ChinaChickenTikkaMasalas001",
        },
        new Item
        {
            Id = 21,
            Name = "Chinese Fried Rice",
            pictureUrl = "/Food/ChineseFriedRice.jpg",
            Country = "China",
            CountryAlias = "Chinese",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 10000020,
            ExternalId = "ChinaChineseFriedRice001",
        },
        new Item
        {
            Id = 22,
            Name = "Ravioli",
            pictureUrl = "/Food/Ravioli.jpg",
            Country = "Italy",
            CountryAlias = "Italian",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 10000020,
            ExternalId = "ItalyRavioli001",
        },
        new Item
        {
            Id = 23,
            Name = "Pasta Salad",
            pictureUrl = "/Food/PastaSalad.jpg",
            Country = "Italy",
            CountryAlias = "Italian",
            DateCreated = DateTime.Parse("24-01-2022"),
            DateModified = DateTime.Parse("24-01-2022"),
            ClassificationId = 10000020,
            ExternalId = "ItalyPastaSalad001",
        }
         );
        }
        public static void seed1(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderStatus>().HasData(
            new OrderStatus
            {
                Orderdate = DateTime.Parse("24-01-2022"),
                OrderId = 101111,
                ItemName = "Potato & Chips",
                Quantity = 3 + "Plates",
                MenuStatus = "Pending",
                Table = 14
            },
            new OrderStatus
            {
                Orderdate = DateTime.Parse("24-01-2022"),
                OrderId = 101112,
                ItemName = "Doro Wot",
                Quantity = 1 + "Plates",
                MenuStatus = "Pending",
                Table = 14
            },
            new OrderStatus
            {
                Orderdate = DateTime.Parse("24-01-2022"),
                OrderId = 101113,
                ItemName = "Bolognese Sauce & Spaghetti",
                Quantity = 1 + "Plates",
                MenuStatus = "Served",
                Table = 2
            },
            new OrderStatus
            {
                Orderdate = DateTime.Parse("24-01-2022"),
                OrderId = 101114,
                ItemName = "Fish Curry",
                Quantity = 6 + "Plates",
                MenuStatus = "Served",
                Table = 9
            },
            new OrderStatus
            {
                Orderdate = DateTime.Parse("24-01-2022"),
                OrderId = 101115,
                ItemName = "Ghana Banku",
                Quantity = 1 + "Plates",
                MenuStatus = "Cancelled",
                Table = 10
            },
            new OrderStatus
            {
                Orderdate = DateTime.Parse("24-01-2022"),
                OrderId = 101116,
                ItemName = "Lamb Vindaloo",
                Quantity = 2 + "Plates",
                MenuStatus = "Pending",
                Table = 8
            },
            new OrderStatus
            {
                Orderdate = DateTime.Parse("24-01-2022"),
                OrderId = 101117,
                ItemName = "Pasta Primavera",
                Quantity = 1 + "Plates",
                MenuStatus = "Served",
                Table = 12
            },
            new OrderStatus
            {
                Orderdate = DateTime.Parse("24-01-2022"),
                OrderId = 101118,
                ItemName = "Cooked Chinese Peppered Lobster",
                Quantity = 1 + "Plates",
                MenuStatus = "Served",
                Table = 5
            }
              );
            modelBuilder.Entity<Sale>().HasData(
                new Sale
                {
                    Id = 10000001,
                    ItemName = "Nigerian Party Jellof Rice",
                    Price = 2.00M,
                    PaymentType = "Stripe",
                    Quantity = 2,
                    RestaurantName = "Happy Restaurant",
                    SaleDate = DateTime.Today,
                    SaleTime = DateTime.Today.TimeOfDay,
                    StaffName = "Happy Cheff1",
                    SumTotal = 4.00M,
                    orderPlacement = "Internal"
                },
                new Sale
                {
                    Id = 10000002,
                    ItemName = "Kimchi",
                    Price = 3.40M,
                    PaymentType = "POS",
                    Quantity = 2,
                    RestaurantName = "Happy Restaurant",
                    SaleDate = DateTime.Today,
                    SaleTime = DateTime.Today.TimeOfDay,
                    StaffName = "Happy Cheff1",
                    SumTotal = 6.80M,
                    orderPlacement = "Internal"
                },
                new Sale
                {
                    Id = 10000003,
                    ItemName = "Kimchi",
                    Price = 2.40M,
                    PaymentType = "POS",
                    Quantity = 4.00M,
                    RestaurantName = "Happy Restaurant",
                    SaleDate = DateTime.Today,
                    SaleTime = DateTime.Today.TimeOfDay,
                    StaffName = "Happy Cheff1",
                    SumTotal = 9.60M,
                    orderPlacement = "Internal"
                },
                new Sale
                {
                    Id = 10000004,
                    ItemName = "Dal Makhani",
                    Price = 1.50M,
                    PaymentType = "POS",
                    Quantity = 2,
                    RestaurantName = "Happy Restaurant",
                    SaleDate = DateTime.Today,
                    SaleTime = DateTime.Today.TimeOfDay,
                    StaffName = "Happy Cheff1",
                    SumTotal = 3.00M,
                    orderPlacement = "Internal"
                },
                new Sale
                {
                    Id = 10000005,
                    ItemName = "Sweet & Sour Soup",
                    Price = 1.20M,
                    PaymentType = "POS",
                    Quantity = 2,
                    RestaurantName = "Happy Restaurant",
                    SaleDate = DateTime.Today,
                    SaleTime = DateTime.Today.TimeOfDay,
                    StaffName = "Happy Cheff1",
                    SumTotal = 2.40M,
                    orderPlacement = "Internal"
                },
                new Sale
                {
                    Id = 10000006,
                    ItemName = "Tofu Mushroom",
                    Price = 5.00M,
                    PaymentType = "POS",
                    Quantity = 1,
                    RestaurantName = "Happy Restaurant",
                    SaleDate = DateTime.Today,
                    SaleTime = DateTime.Today.TimeOfDay,
                    StaffName = "Happy Cheff1",
                    SumTotal = 5.000M,
                    orderPlacement = "Internal"
                },
                new Sale
                {
                    Id = 10000007,
                    ItemName = "Calamari Fries & Chips",
                    Price = 1.00M,
                    PaymentType = "POS",
                    Quantity = 6,
                    RestaurantName = "Happy Restaurant",
                    SaleDate = DateTime.Today,
                    SaleTime = DateTime.Today.TimeOfDay,
                    StaffName = "Happy Cheff1",
                    SumTotal = 6.00M,
                    orderPlacement = "Internal"
                },
                new Sale
                {
                    Id = 10000009,
                    ItemName = "Bimbimbap",
                    Price = 2.00M,
                    PaymentType = "POS",
                    Quantity = 2,
                    RestaurantName = "Happy Restaurant",
                    SaleDate = DateTime.Today,
                    SaleTime = DateTime.Today.TimeOfDay,
                    StaffName = "Happy Cheff1",
                    SumTotal = 4.00M,
                    orderPlacement = "Internal"
                },
                new Sale
                {
                    Id = 10000010,
                    ItemName = "Korma",
                    Price = 2.50M,
                    PaymentType = "POS",
                    Quantity = 2,
                    RestaurantName = "Happy Restaurant",
                    SaleDate = DateTime.Today,
                    SaleTime = DateTime.Today.TimeOfDay,
                    StaffName = "Happy Cheff1",
                    SumTotal = 5.00M,
                    orderPlacement = "Internal"
                }
               );
        }
    }
}