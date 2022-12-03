using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Models
{
    public class Countries
    {
        public int Id { get; set; }
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
        public int CountryClassification { get; set; }
        [Display(Name = "Category Id")]
        public string ClassificationId { get; set; }
    }
}
