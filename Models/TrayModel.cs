using Restaurant_Menu_Organiser.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Models
{
    public class TrayModel
    {
        /// <summary>
        /// Dynamic MODEL ADOPTION
        /// </summary>
        public decimal SumTotal { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string OrderId { get { return string.Format("{0} {1} {2}", DateTime.Now.ToString(), this.StaffName.EmployeeFullName, this.orderPlacement); } }
        public string RestaurantName { get; set; }
        public Employee StaffName { get; set; }
        public string orderPlacement { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime OrderDate { get; set; }
        public string PaymentType { get; set; }

    }
}
