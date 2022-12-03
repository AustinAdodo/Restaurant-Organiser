using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Restaurant_Menu_Organiser.Models.Items
{
    public class Item
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string ExternalId { get; set; }
        public string pictureUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public int ClassificationId { get; set; }
        public string Country { get; set; }
        public string CountryAlias { get; set; }
        public DateTime DateModified { get; set; }
    }
}