using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Menu_Organiser.Data;
using Restaurant_Menu_Organiser.Models.Employees;
using Restaurant_Menu_Organiser.Repositories;
using Restaurant_Menu_Organiser.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Restaurant_Menu_Organiser.Utilities.Services;
using Restaurant_Menu_Organiser.ViewModels;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

//add humanizer namespsace to projects
namespace Restaurant_Menu_Organiser.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserPreferencesServices _userPreferencesServices;
        //private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly ControllerContext _controllerContext;
        //private readonly IWebHostEnvironment _hostinEnvironment;

        public string UserId { get; set; }
        public EmployeesController(ApplicationDbContext context, IEmployeeRepository employeeRepository, 
            UserManager<IdentityUser> userManager,IUserPreferencesServices userPreferencesServices)
        {
            _context = context;
            _userManager = userManager;
            _employeeRepository = employeeRepository;
            _userPreferencesServices = userPreferencesServices;
            UserId = _userPreferencesServices.GetloggedInUserId();
            //UserId2 = _userManager.GetUserId(_httpcontext.User);  
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.UserId = UserId;
            Dictionary<int, Employee> AllEmploy = await _context.Employees.ToDictionaryAsync(a => a.EmployeeId, a => a);
            ViewBag.AllEmployees = AllEmploy;
            return View();
        }
        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }
        // GET: Employees/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        /// <summary>
        /// TO EXTERNAL CALL IN ANGULAR FRONT END SERVER FOR AJAX FOR TYPESCRIPT COMPONENT
        /// </summary>
        public JsonResult RetrieveCurrentEditedEmployee(int empid)
        {
            empid = 2;
            DisposableEmployeeData disposableEmployee = _context.DisposableEmployeesData.Where(a => a.Reference == empid.ToString()).FirstOrDefault();
            Employee EmployeeEq = _context.Employees.Where(a => a.EmployeeId == empid).FirstOrDefault();
            List<PropertyInfo> em = typeof(Employee).GetProperties().OrderBy(c => c.Name).ToList();
            List<PropertyInfo> dem = typeof(DisposableEmployeeData).GetProperties().OrderBy(c => c.Name).ToList(); ;
            List<string> ChangedData = new List<string>();
            for (int i = 0; i < em.Count(); i++)
            {
                for (int p = 0; p < dem.Count(); p++)
                {
                    switch (em[i].Name == dem[p].Name &&
                        em[i].GetValue(EmployeeEq) != null && dem[p].GetValue(disposableEmployee) != null)
                    {
                        case true:
                            string disparity = (em[i].GetValue(EmployeeEq).ToString().Trim() != dem[p].GetValue(disposableEmployee).ToString().Trim()) ?
                              $"{em[i].Name} = {em[i].GetValue(disposableEmployee)}" : "same";
                            ChangedData.Add(disparity); 
                      ChangedData.Distinct(); ChangedData.Remove("same");
                            break; 
                    }
                }
            }//API TEST COMPLETE.
            return Json(ChangedData);
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee emp)
        {
            await _employeeRepository.CreateEmployee(emp);
            return View();
        }

        // GET: Employees/Edit
        [Authorize(Roles = "Admin, ElevatedAccess")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Employees");
                //return notfound();
            }
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return RedirectToAction("Index", "Employees");
                //return NotFound();
            }
            EditEmployeeViewModel EmployeeEdit = new EditEmployeeViewModel
            {
                EmployeeActivities = employee.EmployeeActivities,
                EmployeeBasicAllowance = employee.EmployeeBasicAllowance,
                EmployeeBasicSalary = employee.EmployeeBasicSalary,
                EmployeeDepartment = employee.EmployeeDepartment,
                EmployeeDOB = employee.EmployeeDOB,
                EmployeeEmail = employee.EmployeeEmail,
                EmployeeEmploymentDate = employee.EmployeeEmploymentDate,
                EmployeeFirstName = employee.EmployeeFirstName,
                EmployeeId = employee.EmployeeId,
                EmployeeIdExtId = employee.EmployeeIdExtId,
                EmployeeImagePath = employee.EmployeeImagePath,
                EmployeeLastName = employee.EmployeeLastName,
                EmployeeLGAOfOrigin = employee.EmployeeLGAOfOrigin,
                EmployeeMiddleName = employee.EmployeeMiddleName,
                EmployeeNationality = employee.EmployeeNationality,
                EmployeeOtherAllowance = employee.EmployeeOtherAllowance,
                EmployeePhoneNumber = employee.EmployeePhoneNumber,
                EmployeeResidence = employee.EmployeeResidence,
                EmployeeSex = employee.EmployeeSex,
                EmployeeStateOfOrigin = employee.EmployeeStateOfOrigin,
                EmployeeStatus = employee.EmployeeStatus
            };
            ViewBag.EmployeeFullName = employee.EmployeeFullName;
            ViewBag.EmployeeId = employee.EmployeeId;
            ViewBag.EmployeeExtId = employee.EmployeeIdExtId;
            return View(EmployeeEdit);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ApprovalRequiredForAction(RequestingRoles = "ElevatedAccess", Action = "Edit Employee")]
        public async Task<IActionResult> Edit(EditEmployeeViewModel model, int id, string UserId)
        {
            id = (User.IsInRole("ElevatedAccess")) ? 0 : 0;
            UserId = (User.IsInRole("ElevatedAccess")) ? null : "Ignore";
            var Emp = (_context.Employees.Where(a => a.EmployeeId == model.EmployeeId).FirstOrDefault()) ?? null;
            if (Emp != null)
            {
                Emp.EmployeeIdExtId = model.EmployeeIdExtId;
                Emp.EmployeeFirstName = model.EmployeeFirstName;
                Emp.EmployeeMiddleName = model.EmployeeMiddleName;
                Emp.EmployeeLastName = model.EmployeeLastName;
                Emp.EmployeeImagePath = model.EmployeeImagePath;
                Emp.EmployeeSex = model.EmployeeSex;
                Emp.EmployeeNationality = model.EmployeeNationality;
                Emp.EmployeeEmail = model.EmployeeEmail;
                Emp.EmployeeDOB = model.EmployeeDOB;
                Emp.EmployeeEmploymentDate = model.EmployeeEmploymentDate;
                Emp.EmployeeBasicSalary = model.EmployeeBasicSalary;
                Emp.EmployeeBasicAllowance = model.EmployeeBasicAllowance;
                Emp.EmployeeOtherAllowance = model.EmployeeOtherAllowance;
                Emp.EmployeePhoneNumber = model.EmployeePhoneNumber;
                Emp.EmployeeResidence = model.EmployeeResidence;
                Emp.EmployeeStatus = model.EmployeeStatus;
                Emp.EmployeeStateOfOrigin = model.EmployeeStateOfOrigin;
                Emp.EmployeeLGAOfOrigin = model.EmployeeLGAOfOrigin;
                Emp.EmployeeActivities = model.EmployeeActivities;
                Emp.EmployeeDepartment = model.EmployeeDepartment;
            }
            await _employeeRepository.UpdateEmployee(Emp);
            ViewBag.Updates = "Edits applied successfully";
            return RedirectToAction("Index", "Employees");
        }

        // GET: Employees/Delete/5
        [Authorize(Roles = "Admin, ElevatedAccess")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [ApprovalRequiredForAction(RequestingRoles = "ElevatedAccess", Action = "Delete Employee")]
        public IActionResult DeleteConfirmed(int id, string UserId)
        {
            _employeeRepository.DeleteEmployee(id);
            return RedirectToAction("Index", "Employees");
        }
        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
        
    }
}
//return RedirectToAction(nameof(Index));
//[TypeFilter(typeof(ApprovalRequiredForActionAttribute), Arguments= new object[] { "ElevatedAccess", "Delete Employee" })]
//ViewBag.ActionName = _controllerContext.RouteData.Values["action"].ToString();
