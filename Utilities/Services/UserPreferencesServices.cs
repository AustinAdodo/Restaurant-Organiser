using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Menu_Organiser.Data;
using Restaurant_Menu_Organiser.Models.Approvals;
using Restaurant_Menu_Organiser.Models.Employees;
using Restaurant_Menu_Organiser.Models.Notifications;
using Restaurant_Menu_Organiser.Repositories;
using Restaurant_Menu_Organiser.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Utilities.Services
{
    public class UserPreferencesServices : IUserPreferencesServices
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly INotificationsService _notificationsService;
        private readonly IApprovalsRepository _approvalsRepository;
        private readonly ApplicationDbContext _context;

        public Task<IdentityUser> User { get { return GetloggedInUser(); } }///AsyncCallback;

        public string Id { get { return GetloggedInUserId(); } }

        public UserPreferencesServices(UserManager<IdentityUser> userManager,
            IHttpContextAccessor contextAccessor, IEmployeeRepository employeeRepository,
            INotificationsService notificationsService, IApprovalsRepository approvalsRepository, ApplicationDbContext context)
        {
            _contextAccessor = contextAccessor;
            _userManager = userManager;
            _employeeRepository = employeeRepository;
            _notificationsService = notificationsService;
            _approvalsRepository = approvalsRepository;
            _context = context;
        }

        public async Task<IdentityUser> GetloggedInUser()
        {
            var user = await _userManager.FindByIdAsync(Id);
            return user;
        }

        public async Task<bool> IsInRole(string role)
        {
            bool condition = await _userManager.IsInRoleAsync(User.Result, role);
            return condition;
        }

        //comments needed.
        public string GetloggedInUserId()
        {
            return _contextAccessor.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public bool IsAuthenticated()
        {
            return _contextAccessor.HttpContext.User.Identity.IsAuthenticated;
        }

        public static string SuccessStatusMessage(string action, string otherParam)
        {
            return "The Action to " + action + " with corresponding of Id : " + otherParam + " has been redirected to someone with the required elevated access for approval";
        }

        public static string FailedStatusMessage()
        {
            return "There was an issue sending your request for its required approval, your request was not submitted, try again or contact Admin.";
        }

        public async Task<bool> ExecuteApproval(string RequestingRoles, string Action, string Id, object model)
        {
            var UserId = GetloggedInUserId();
            EditEmployeeViewModel modelling = (EditEmployeeViewModel)model;
            string SuperiorRoles = "Admin";
            string RouteParameters = (Action == "Delete Employee") ? Id : (Action == "Edit Employee") ? modelling.EmployeeId.ToString():
                       (Action == "Delete Item") ? "Delete Item Request" : (Action == "Edit Item") ? "Edit Item Request" : "Default";
            string EmployeeFullName = _employeeRepository.GetSpecificEmployee(User.Result.Email.ToString()).EmployeeFullName;
            if (await _userManager.IsInRoleAsync(User.Result, RequestingRoles))
            {
                switch (Action)
                {
                    case "Delete Employee":
                        var CurrentApproval = new Approval()
                        {
                            ///save the object to the approval parameters of target person and redirect to action for the current person logged on
                            Name = "'Delete Employee Request' from " + EmployeeFullName + " of 'AccessRoleType' : " + RequestingRoles + " and UserId : " + UserId + " Requesting Employee of id : "
                            + RouteParameters + " to be deleted ",
                            Parameters = RouteParameters,
                            OriginRole = RequestingRoles,
                            TargetRole = SuperiorRoles,
                            status = "Pending",
                            Date = string.Format("{0}/{1}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year),
                            TargetRolePersonel = "6981a626-7718-4a35-a210-f435c7e5d49c",/////// to be made dynamic from heirachy table
                            OriginRolePersonel = Id,
                            Time = string.Format("{0}:{1}", DateTime.Now.TimeOfDay.Hours, DateTime.Now.TimeOfDay.Minutes),
                            ApprovalType = (Action == "Delete Employee") ? "Delete Employee Request" : (Action == "Edit Employee") ? "Edit Employee Request" :
                        (Action == "Delete Item") ? "Delete Item Request" : (Action == "Edit Item") ? "Edit Item Request" : "Default",
                        };
                        await _approvalsRepository.AddNewApproval(CurrentApproval);
                        int ApprovalId = _context.Approvals.OrderByDescending(a => a.Id).First().Id;
                        Approval approvalUpdate = _approvalsRepository.GetApproval(ApprovalId);
                        IdentityUser superiorUser = _userManager.Users.Where(a => a.Id == "6981a626-7718-4a35-a210-f435c7e5d49c").FirstOrDefault() ?? User.Result;
                        var RespectiveNotification = new Notification()
                        {
                            NameHeader = approvalUpdate.ApprovalType,
                            Body = approvalUpdate.Name,
                            Department = RequestingRoles,
                            Status = "Opened",
                            ConsumerId = superiorUser.Id,
                            DateandTime = string.Format("Date : {0} : {1}", approvalUpdate.Date, approvalUpdate.Time),
                            Type = "Employee CRUD operation"
                        };
                        ////Update Notifications
                        await _notificationsService.Add(RespectiveNotification);
                        string msg = UserPreferencesServices.SuccessStatusMessage(Action, Id);
                        var RespectiveNotification1 = new Notification()
                        {
                            NameHeader = "Success",
                            Body = msg,
                            Department = RequestingRoles,
                            Status = "Opened",
                            DateandTime = string.Format("Date : {0} : {1}", approvalUpdate.Date, approvalUpdate.Time),
                            Type = "Feedback",
                            ConsumerId = UserId
                        };
                        await _notificationsService.Add(RespectiveNotification1);
                        break;
                    case "Edit Employee":
                        var CurrentApproval1 = new Approval()
                        {
                            Name = "An 'Edit Request' from " + EmployeeFullName + " with 'Priviledge' : " + RequestingRoles + " and UserId : "
                            + UserId + " requesting to apply updates the resource of type Employee with id : " + RouteParameters + ".",
                            Parameters = RouteParameters,
                            OriginRole = RequestingRoles,
                            TargetRole = SuperiorRoles,
                            status = "Pending",
                            Date = string.Format("{0}/{1}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year),
                            TargetRolePersonel = "6981a626-7718-4a35-a210-f435c7e5d49c",/////// to be made dynamic from heirachy table
                            OriginRolePersonel = Id,
                            Time = string.Format("{0}:{1}", DateTime.Now.TimeOfDay.Hours, DateTime.Now.TimeOfDay.Minutes),
                            ApprovalType = (Action == "Delete Employee") ? "Delete Employee Request" : (Action == "Edit Employee") ? "Edit Employee Request" :
                       (Action == "Delete Item") ? "Delete Item Request" : (Action == "Edit Item") ? "Edit Item Request" : "Default",
                        };
                        await _approvalsRepository.AddNewApproval(CurrentApproval1);
                        int ApprovalId1 = _context.Approvals.OrderByDescending(a => a.Id).First().Id;
                        Approval approvalUpdate1 = _approvalsRepository.GetApproval(ApprovalId1);
                        var EditEmployeeParamters = new DisposableEmployeeData()
                        {
                            Reference = modelling.EmployeeId.ToString(),
                            EmployeeFirstName = modelling.EmployeeFirstName,
                            EmployeeStatus = modelling.EmployeeStatus,
                            EmployeeLastName = modelling.EmployeeLastName,
                            EmployeeMiddleName = modelling.EmployeeMiddleName,
                            EmployeeActivities = modelling.EmployeeActivities,
                            EmployeeSex = modelling.EmployeeSex,
                            EmployeeDOB = modelling.EmployeeDOB,
                            EmployeeDepartment = modelling.EmployeeDepartment,
                            EmployeeBasicSalary = modelling.EmployeeBasicSalary,
                            EmployeeEmail = modelling.EmployeeEmail,
                            EmployeeIdExtId = modelling.EmployeeIdExtId,
                            EmployeeEmploymentDate = modelling.EmployeeEmploymentDate,
                            LocalReference = approvalUpdate1.Id.ToString(),
                            EmployeeBasicAllowance = modelling.EmployeeBasicAllowance,
                            EmployeeImagePath = modelling.EmployeeImagePath,
                            EmployeeLGAOfOrigin = modelling.EmployeeLGAOfOrigin,
                            EmployeeNationality = modelling.EmployeeNationality,
                            EmployeeOtherAllowance = modelling.EmployeeOtherAllowance,
                            EmployeePhoneNumber = modelling.EmployeePhoneNumber,
                            EmployeeResidence = modelling.EmployeeResidence,
                            EmployeeStateOfOrigin = modelling.EmployeeStateOfOrigin,
                            TimeAdded = DateTime.Now.TimeOfDay,
                            DateAdded = DateTime.Now.Date
                        };
                        await _employeeRepository.CreateDEmployee(EditEmployeeParamters);
                        /// create enum that defines heirachy of target user
                        IdentityUser superiorUser1 = _userManager.Users.Where(a => a.Id == "6981a626-7718-4a35-a210-f435c7e5d49c").FirstOrDefault() ?? User.Result;
                        var RespectiveNotificationA = new Notification()//Target User Nofification.
                        {
                            NameHeader = approvalUpdate1.ApprovalType,
                            Body = approvalUpdate1.Name,
                            Department = RequestingRoles,
                            Status = "Opened",
                            ConsumerId = superiorUser1.Id,
                            DateandTime = string.Format("Date : {0} : {1}", approvalUpdate1.Date, approvalUpdate1.Time),
                            Type = "Employee CRUD operation"
                        };
                        await _notificationsService.Add(RespectiveNotificationA);
                        string editmsg = UserPreferencesServices.SuccessStatusMessage(Action, Id);
                        var RespectiveNotificationA1 = new Notification()///User Notification upon redirect
                        {
                            NameHeader = "Success",
                            Body = editmsg,
                            Department = RequestingRoles,
                            Status = "Opened",
                            DateandTime = string.Format("Date : {0} : {1}", approvalUpdate1.Date, approvalUpdate1.Time),
                            Type = "Feedback",
                            ConsumerId = UserId
                        };
                        await _notificationsService.Add(RespectiveNotificationA1);
                        break;
                    case "Create Employee":
                        ///////Delegate Instructions.......
                        break;
                }

                return true;
            }
            else
            {
                    return false;
            }
        }
    }
}
//INJECTING A SERVICE INTO ANOTHER SERVICE CAN GIVE RISE TO A STACK EXEPTION OR A CONCURRENCY EXCEPTION.
///
