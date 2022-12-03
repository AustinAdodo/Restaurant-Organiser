using System.ComponentModel.DataAnnotations;

namespace Restaurant_Menu_Organiser.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}