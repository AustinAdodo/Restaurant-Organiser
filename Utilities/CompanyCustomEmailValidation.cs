using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Utilities
{
    public class CompanyCustomEmailValidation :ValidationAttribute
    {
        private readonly string _currentAllowedDomain;
        public CompanyCustomEmailValidation(string CurrentAllowedDomain)
        {
            _currentAllowedDomain = CurrentAllowedDomain;
        }
        public override bool IsValid(object value)
        {
            string[] mudiadomain = value.ToString().Split("@");
            return mudiadomain[1].ToUpper() == _currentAllowedDomain.ToUpper();
        }
    }
}
