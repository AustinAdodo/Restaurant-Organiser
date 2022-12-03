using Restaurant_Menu_Organiser.Models.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Models
{
    public class SaleSummaryModel
    {
        public class Sale
        {
            [Key]
            [Display(Name = "This Sale Id")]
            public string ReferenceId
            {
                get
                {
                    return string.Format("{0}{1}{2}{3}{4}", DateTime.Now.ToString(), this.RestaurantName,
                    this.StaffName.EmployeeFullName, this.orderPlacement, this.SumTotal);
                }
            }
            public decimal SumTotal { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            [Display(Name = "This Sale Id")]

            public string RestaurantName { get; set; }
            public string orderPlacement { get; set; }
            public string PaymentType { get; set; }
            public DateTime SaleDateandTime { get; set; }
            public Employee StaffName { get; set; }
        }
    }
}
