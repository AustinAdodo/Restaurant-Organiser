using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Models.Approvals
{
    public class Approval
    {
        [Required]
        public int Id { get; set; }
        public string OriginRolePersonel { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string ApprovalType { get; set; }
        public string status { get; set; }
        public string OriginRole { get; set; }
        public string TargetRole { get; set; }
        public string TargetRolePersonel { get; set; }
        public string Parameters { get; set; }
    }
}
