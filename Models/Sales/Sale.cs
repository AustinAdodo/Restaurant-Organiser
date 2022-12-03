using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Restaurant_Menu_Organiser.Data;
using Restaurant_Menu_Organiser.Models.Employees;

namespace Restaurant_Menu_Organiser.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        //public string SaleExdId { get; set; }
        public decimal SumTotal { get; set; }
        public string ItemName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string RestaurantName { get; set; }
        public string orderPlacement { get; set; }
        public string PaymentType { get; set; }
        public DateTime SaleDate { get; set; }
        public TimeSpan SaleTime { get; set; }
        public string StaffName { get; set; }
    }
}
