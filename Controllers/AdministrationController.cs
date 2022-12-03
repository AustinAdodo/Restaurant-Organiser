using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurant_Menu_Organiser.Data;
using Restaurant_Menu_Organiser.Models.Employees;
using Restaurant_Menu_Organiser.Repositories;
using Restaurant_Menu_Organiser.ViewModels;

namespace Restaurant_Menu_Organiser.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmployeeRepository _employeeRepository;

        public AdministrationController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<IdentityUser> userManager, IEmployeeRepository employeeRepository)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
            _employeeRepository = employeeRepository;
        }

        // GET: Overview including approvals , generate procurement Order etc
        //Show All ROLES
        public IActionResult Index()
        {
            var allUsers = _userManager.Users;
            ViewBag.Users = allUsers;
            return View(_roleManager.Roles);
        }
        public JsonResult RetrieveRoles(string roleId)
        {
            var QueriedRole = _roleManager.Roles.Where(a => a.Id == roleId).FirstOrDefault();
            return Json(QueriedRole);
        }
        public async Task<IActionResult> ToggleEmployeeStatus(string EmployeeId)
        {
            int.TryParse(EmployeeId, out int Id);
            var employeeQuery = await _context.Employees.FindAsync(Id);
            await _employeeRepository.DeActivateEmployee(employeeQuery);
            return Json(employeeQuery);
        }

        // GET: Administration/Role Details/
        public IActionResult RoleDetails(string id)
        {
            return View();
        }
        // GET: Administration/CreateRole
        [Authorize]
        public IActionResult CreateRole()
        {
            return View();
        }

        // POST: Administration/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName,
                };
                var RoleCreateResult = await _roleManager.CreateAsync(identityRole);
                if (RoleCreateResult.Succeeded)
                {
                    return RedirectToAction("Index", "Administration");
                }
                foreach (IdentityError Error in RoleCreateResult.Errors)
                {
                    ModelState.AddModelError("", Error.Description);
                }
            }
            return View(model);
        }

        // GET: Administration/Edit/5
        public async Task<IActionResult> EditRole(string Id)
        {
            var role = await _roleManager.FindByIdAsync(Id);
            if (role == null)

            {
                ViewBag.ErrorMesssage = string.Format("The Role with Id {0} Cannot be found, Contact Admin for more details", role);
                return NotFound();
            }
            EditRoleViewModel modeledit = new EditRoleViewModel
            {
                RoleId = role.Id,
                RoleName = role.Name,
            };
            foreach (var user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    modeledit.UsersInThisRole.Add(user.UserName);
                }
            }
            return View(modeledit);
        }

        // POST: Administration/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.RoleId);
            if (role == null)

            {
                ViewBag.ErrorMesssage = string.Format("The Role with Id {0} Cannot be found or was recently deleted, Contact Admin for more details", role);
                return NotFound();
            }
            role.Id = model.RoleId;
            role.Name = model.RoleName;
            var result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Administration");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EditUsersInARole(string Id)
        {
            var role = await _roleManager.FindByIdAsync(Id);
            if (role == null)
            {
                return View("NotFound");
            }
            var model = new List<UserRoleViewModel>();
            foreach (var user in _userManager.Users)
            {
                var UserEquivalent = _context.Employees.Where(a => a.EmployeeEmail == user.Email).FirstOrDefault();
                var userRoleVm = new UserRoleViewModel()
                {
                    Fullname = UserEquivalent.EmployeeFullName,
                    UserId = user.Id,
                    UserName = user.UserName
                };
                userRoleVm.IsSelected = (await _userManager.IsInRoleAsync(user, Id)) ? true : false;
                model.Add(userRoleVm);
            }
            string rname = await _roleManager.GetRoleNameAsync(role);
            ViewBag.RoleName = rname;
            ViewBag.RoleId = Id;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUsersInARole(List<UserRoleViewModel> modelcollection, string RoleId)
        {
            var role = await _roleManager.FindByIdAsync(RoleId);
            for (int i = 0; i < modelcollection.Count; i++)
            {
                IdentityResult result = null;
                var User = await _userManager.FindByIdAsync(modelcollection[i].UserId);
                if (User == null)
                {
                    return View("NotFound");
                }
                if (modelcollection[i].IsSelected && !(await _userManager.IsInRoleAsync(User, role.Name)))
                {
                    ///user is just added to this role
                    result = await _userManager.AddToRoleAsync(User, role.Name);
                }
                if (!modelcollection[i].IsSelected && (await _userManager.IsInRoleAsync(User, role.Name)))
                {
                    //user was in this role but now removed
                    result = await _userManager.RemoveFromRoleAsync(User, role.Name);

                }
                else
                {
                    continue;
                }
                if (result.Succeeded)
                {
                    if (i < modelcollection.Count - 1)
                    {
                        continue;
                    }
                    else
                    {
                        //return RedirectToAction("EditUsersInARole", new { Id = RoleId });
                        return RedirectToAction("Index", "Administration");
                    }
                }
            }
            return RedirectToAction("Index", "Administration");
        }
        // GET: Administration/Delete/5
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

        // POST: Administration/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }
}

