using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Models
{
    public class OrderStatus
    {
        [Key]
        public int OrderId { get; set; }
        public int Table { get; set; }
        public string MenuStatus { get; set; }
        public string ItemName { get; set; }
        public string Quantity { get; set; }
        public DateTime Orderdate { get; set; }
    }
}
