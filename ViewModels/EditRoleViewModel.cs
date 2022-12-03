using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.ViewModels
{
   
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            ///null reference
            UsersInThisRole = new List<string>();
        }
        public string RoleId { get; set; }
        [Required(ErrorMessage="Role Name Is Required")]
        public string RoleName { get; set; }
        public List<string> UsersInThisRole { get; set; }

    }
}
