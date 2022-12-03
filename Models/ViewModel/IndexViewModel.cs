using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant_Menu_Organiser.Models.Employees;
using Restaurant_Menu_Organiser.Models.Items;

namespace Restaurant_Menu_Organiser.Models.ViewModel
{
    public class IndexViewModel
    {
        public Employee CurrentUser { get; set; }
        public Item Item { get; set; }
        public Sale Sale { get; set; }
        public Countries CountryName { get; set; }
        public MajorMenuCategory CategoryName { get; set; }

    }
}
