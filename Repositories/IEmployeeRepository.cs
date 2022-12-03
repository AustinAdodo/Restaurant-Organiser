using Restaurant_Menu_Organiser.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Repositories
{
    public interface IEmployeeRepository
    {
        public List<string> GetEmployeeCredentials(List<string> CredentialPhotoPath);
        public IEnumerable<Employee> GetAllEmployees();
        public Employee GetSpecificEmployee(int? id);
        public Employee GetSpecificEmployee(string email);
        public void DeleteEmployee(int id);
        public Task<Employee> UpdateEmployee(Employee EmployeeChanges);
        public Task<DisposableEmployeeData> UpdateEmployee(DisposableEmployeeData EmployeeChanges);
        public Task<Employee> CreateEmployee(Employee Employee);
        public Task<DisposableEmployeeData> CreateDEmployee(DisposableEmployeeData DEmployee);
        public Employee GetEmployeeOperationSummary();
        public Task<string> DeActivateEmployee(Employee employeeStatus);
        public List<Employee> RetrieveSpecificEmployeeSet();
        //public IEnumerable<Employee_Model> DeleteMultipleEmployees(List<string> identities);
    }
}
