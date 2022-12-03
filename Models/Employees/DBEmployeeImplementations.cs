using Restaurant_Menu_Organiser.Data;
using Restaurant_Menu_Organiser.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Models.Employees
{
    public class DBEmployeeImplementations : IEmployeeRepository
    {
        //private List<Employee_Model> _employeeList;
        private readonly ApplicationDbContext _employeeContext;
        private readonly ApplicationDbContext _DisposableEmployeeContext;
        public DBEmployeeImplementations(ApplicationDbContext EmployeeContext, ApplicationDbContext DisposableEmployeeContext)
        {
            this._employeeContext = EmployeeContext;
            this._DisposableEmployeeContext = DisposableEmployeeContext;
        }

        public List<string> GetEmployeeCredentials(List<string> CredentialPhotoPath)
        {
            List<string> RetrievedCredentials = new List<string>();
            return RetrievedCredentials;
        }
        public async Task<Employee> CreateEmployee(Employee Employee)
        {
            _employeeContext.Add(Employee);
            await _employeeContext.SaveChangesAsync();
            return Employee;
        }
        public async Task<DisposableEmployeeData> CreateDEmployee(DisposableEmployeeData DEmployee)
        {
            _DisposableEmployeeContext.Add(DEmployee);
            await _DisposableEmployeeContext.SaveChangesAsync();
            return DEmployee;
        }
        public async void DeleteEmployee(int id)
        {
            Employee FoundEquivalentEmp = _employeeContext.Employees.Find(id);
            //DisposableEmployeeData FoundEquivalentDisposableEmp =_DisposableEmployeeContext.DisposableEmployeesData.Find(id);
            //   //var FoundEmployee = equivalentDisposableEmp ?? equivalentEmp;
            //if (FoundEquivalentDisposableEmp != null )
            //{
            //_DisposableEmployeeContext.DisposableEmployeesData.Remove(FoundEquivalentDisposableEmp);
            //await _employeeContext.SaveChangesAsync();
            //}
            _employeeContext.Employees.Remove(FoundEquivalentEmp);
            await _employeeContext.SaveChangesAsync();
        }
        /// <summary>
        /// Deleting a set of employees requires high level Approval and should be avoided except extremely Necessary.
        /// </summary>
        /// <param name="identities"></param>
        public async void DeleteMultipleEmployees(List<string> identities)
        {
            foreach (string identity in identities)
            {
                IEnumerable<Employee> FoundEmployees = _employeeContext.Employees.Where(a => a.EmployeeIdExtId == identity);
                foreach (Employee employee in FoundEmployees)
                {
                    if (FoundEmployees != null)
                    {
                        _employeeContext.Employees.Remove(employee);
                        await _employeeContext.SaveChangesAsync();
                    }
                }
            }
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeContext.Employees;
        }
        public Employee GetSpecificEmployee(int? id)
        {
            return _employeeContext.Employees.Find(id);
        }
        public Employee GetSpecificEmployee(string email)
        {
            return _employeeContext.Employees.Where(a => a.EmployeeEmail == email).FirstOrDefault();
        }
        public async Task<Employee> UpdateEmployee(Employee EmployeeChanges)
        {
            var EditedEmployee = _employeeContext.Employees.Attach(EmployeeChanges);
            EditedEmployee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _employeeContext.SaveChangesAsync();
            return EmployeeChanges;
        }
        public async Task<DisposableEmployeeData> UpdateEmployee(DisposableEmployeeData EmployeeChanges)
        {
            var EditedEmployee = _DisposableEmployeeContext.DisposableEmployeesData.Attach(EmployeeChanges);
            EditedEmployee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _DisposableEmployeeContext.SaveChangesAsync();
            return EmployeeChanges;
        }
        public Employee GetEmployeeOperationSummary()
        {
            throw new NotImplementedException();
        }
        public List<Employee> RetrieveSpecificEmployeeSet()
        {
            throw new NotImplementedException();
        }
        public async Task<string> DeActivateEmployee(Employee employee)
        {
            //string employeeStatus = "";
            employee.EmployeeStatus = (employee.EmployeeStatus == "Active") ? "Inactive" : "Active";
            await this.UpdateEmployee(employee);
            return employee.EmployeeStatus;
        }
    }
}
