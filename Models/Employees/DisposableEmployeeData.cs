using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Restaurant_Menu_Organiser.Models.Employees
{
    public class DisposableEmployeeData : BaseEmployee
    {
        public DateTime DateAdded { get; set; }
        public TimeSpan TimeAdded { get; set; }
        public string Reference { get; set; }
        public string LocalReference { get; set; }
    }
}
