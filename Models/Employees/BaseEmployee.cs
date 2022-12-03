using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Models.Employees
{
    public abstract class BaseEmployee
    {
        [Required]
        [Display(Name = "Access Level")]
        private string EmployeeAccessLevel { get; set; }
        [Required]
        [Display(Name = "Current Status")]
        public string EmployeeStatus { get; set; }
        [Required]
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string EmployeeFullName { get { return string.Format("{0} {1} {2}", this.EmployeeFirstName, this.EmployeeMiddleName, this.EmployeeLastName); } }

        [Required]
        public string EmployeeLastName { get; set; }

        [Required]
        [RegularExpression(@"\d{4,7}", ErrorMessage = "Salary must be between 4 and 7 digits")] //regex for 4 to 7 digits
        [DataType(DataType.Currency, ErrorMessage = "Format must be of Currency Type")]
        [Display(Name = "Basic Salary")]
        public decimal EmployeeBasicSalary { get; set; }//datatype set to currency

        [Required]
        [RegularExpression(@"\d{0,7}", ErrorMessage = "Salary must be between 3 and 7 digits")] //regex for 3 to 7 digits
        [DataType(DataType.Currency, ErrorMessage = "Format must be of Currency Type")]
        [Display(Name = "Allowance Basic")]
        public decimal EmployeeBasicAllowance { get; set; }//datatype set to currency

        [Required]
        [RegularExpression(@"\d{0,7}", ErrorMessage = "Salary must be between 3 and 7 digits")] //regex for 3 to 7 digits
        [DataType(DataType.Currency, ErrorMessage = "Format must be of Currency Type")]
        [Display(Name = "Other Allowance(s)")]
        public decimal EmployeeOtherAllowance { get; set; }//datatype set to currency
        [Required]
        public string EmployeeFirstName { get; set; }

        public string EmployeeMiddleName { get; set; }

        [Display(Name = "Photo Path")]
        public string EmployeeImagePath { get; set; }

        [Required]
        [Display(Name = "Employee Id")]
        //Employee external ID or ProductCode
        public string EmployeeIdExtId { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime EmployeeDOB { get; set; }

        //Product internal cost price

        [Required]
        [Display(Name = "Date Of Employment")]
        public DateTime EmployeeEmploymentDate { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string EmployeeSex { get; set; }

        [Required]
        [Display(Name = "Department")]
        public string EmployeeDepartment { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string EmployeePhoneNumber { get; set; }
        [Display(Name = "Email Address")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Invalid Email Format")]
        //[EmailDomainValidationAttribute(ValidDomain: "mudiabusiness.com", ErrorMessage = "Valid domain is strictly mapped and specified to mudia and must be mudiabusiness.com ")]
        public string EmployeeEmail { get; set; }

        [Required]
        [Display(Name = "Home Address")]
        public String EmployeeResidence { get; set; }
        [Required]
        [Display(Name = "Nationality")]
        public String EmployeeNationality { get; set; }
        [Required]
        [Display(Name = "State Of Origin")]
        public String EmployeeStateOfOrigin { get; set; }
        [Required]
        [Display(Name = "Local Governmant Area Of Origin")]
        public String EmployeeLGAOfOrigin { get; set; }

        [Required]
        [Display(Name = "Activity Log")]
        [StringLength(50000, MinimumLength = 0)]
        //Employee Activty Log
        public String EmployeeActivities { get; set; }

        [StringLength(50000, MinimumLength = 0)]
        //Employee Activty Log
        public String EmployeeRemarks { get; private set; }


    }
}
