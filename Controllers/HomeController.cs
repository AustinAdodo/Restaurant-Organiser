using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant_Menu_Organiser.Models;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Restaurant_Menu_Organiser.Data;
using Restaurant_Menu_Organiser.Models.Items;
using Restaurant_Menu_Organiser.ViewModels;
using Restaurant_Menu_Organiser.Utilities.Services;
using Restaurant_Menu_Organiser.Models.Notifications;
using Restaurant_Menu_Organiser.Models.Approvals;
using Restaurant_Menu_Organiser.Models.Employees;

namespace Restaurant_Menu_Organiser.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _UserManager;
        private readonly IUserPreferencesServices _userPreferencesServices;
        private readonly INotificationsService _notificationsService;
        private readonly IApprovalsRepository _approvalsRepository;
        public string UserId { get; set; }
        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger, UserManager<IdentityUser> UserManager,
         SignInManager<IdentityUser> signInManager, IUserPreferencesServices userPreferencesServices, INotificationsService notificationsService, IApprovalsRepository approvalsRepository)
        {
            _context = context;
            _logger = logger;
            _UserManager = UserManager;
            _signInManager = signInManager;
            _userPreferencesServices = userPreferencesServices;
            UserId = _userPreferencesServices.GetloggedInUserId();
            _notificationsService = notificationsService;
            _approvalsRepository = approvalsRepository;
        }

        [AllowAnonymous]
        [AcceptVerbs("Get", "Post")]
        public async Task<IActionResult> ExistingEmailCheck(string QueryEmail)
        {
            var RegisteringEmployee = await _UserManager.FindByEmailAsync(QueryEmail);
            if (RegisteringEmployee == null)
            {
                return Json(true);
            }
            else
            {
                return Json(string.Format("The email {0} is currently used by another Employee", RegisteringEmployee));
            }
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(LoginViewModel model, string RetrunUrl)
        {
            Employee equivalentEmployee = _context.Employees.Where(a => a.EmployeeEmail == model.Email).FirstOrDefault();
            if (ModelState.IsValid && equivalentEmployee.EmployeeStatus== "Active")
            {
                model.RememberMe = false;
                var ResultFailed = Microsoft.AspNetCore.Identity.SignInResult.Failed;
                var result = (await _signInManager.PasswordSignInAsync(model.Email, model.EmployeePassword, model.RememberMe, false)) ?? ResultFailed;
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(RetrunUrl) && Url.IsLocalUrl(RetrunUrl))
                    {
                        return Redirect(RetrunUrl);
                    }
                    return RedirectToAction("Activity", "Home");
                }
                else
                {
                    return View("Index");
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Your Current Login is not Authorised or Your Login Details are invalid, Contact Admin" +
                    "if more than 3 attempts, DO NOT attempt to Login further");
            }
            return View(model);
        }
        [AllowAnonymous]
        public IActionResult ClientIndex()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Activity()
        {
            int chinaid = _context.Items.Where(a => a.Country == "China").Select(a => a.ClassificationId).First();
            int Koreaid = _context.Items.Where(a => a.Country == "South-Korea").Select(a => a.ClassificationId).First();
            int Ghanaid = _context.Items.Where(a => a.Country == "Ghana").Select(a => a.ClassificationId).First();
            int NigeriaId = _context.Items.Where(a => a.Country == "Nigeria").Select(a => a.ClassificationId).First();
            int Italyid = _context.Items.Where(a => a.Country == "Italy").Select(a => a.ClassificationId).First();
            int Indiaid = _context.Items.Where(a => a.Country == "India").Select(a => a.ClassificationId).First();
            ViewBag.ChineseId = chinaid; ViewBag.Koreaid = Koreaid; ViewBag.Ghanaid = Ghanaid; ViewBag.NigeriaId = NigeriaId; ViewBag.Italyid = Italyid; ViewBag.Indiaid = Indiaid;
            ViewBag.DefaultItems = _context.Items.Where(a => a.Country == "South-Korea").ToDictionary(a => a.Id, a => a);
            ViewBag.Orders = _context.Orders.ToDictionary(a => a.ItemName, a => a);
            ViewBag.Sales = _context.Sales.Where(a => a.StaffName == "Happy Cheff1").ToDictionary(a => a.Id, a => a);
            ViewBag.Grandtotal = _context.Sales.Sum(a => a.SumTotal);
            ///Deploy User Notifications
            List<Notification> UserNotifications = _context.Notifications.Where(a => a.ConsumerId == UserId).ToList();
            ViewBag.TotalNotificationCount = UserNotifications.Count();
            ViewBag.NotificationCount = UserNotifications.Count(a => a.Status == "Opened");
            Dictionary<int, Notification> NotificationBody =
              _context.Notifications.Where(a => a.ConsumerId == UserId).ToDictionary(a => a.Id, a => a);
            ViewBag.NotificationBody = NotificationBody;
            return View();
        }
        public IActionResult RenderModalDetails()
        {
            return PartialView();
        }
        /// <summary>
        /// REGISTER
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.Title = "Register a new account for an employee";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                { UserName = model.Email, Email = model.Email };
                var result = await _UserManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }
                else foreach (var err in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, err.Description);
                    }
            }
            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// GROUP OF JSONRESULT DATA TO BE PASSED TO TREE MENU .
        /// </summary>
        /// <param name="PiD"></param>
        /// <returns></returns>
        public JsonResult PopulateTreeView(string country)
        {
            //int Pid = 0;
            IEnumerable<Item> TargetMenuGrouping = _context.Items.Where(a => a.Country == country).OrderBy(a => a.Name).ToList();
            return new JsonResult(TargetMenuGrouping);
        }
        public async Task<JsonResult> UpdateNotificationsandRecords(string NotificationId, string PassedData)
        {
            int nId = 0; int.TryParse(NotificationId, out nId);
            Notification notification = _context.Notifications.Where(a => a.Id == nId).FirstOrDefault();
            string header = notification.NameHeader;
            Approval eqApproval = _context.Approvals.Where(a => a.ApprovalType.Trim() == header.Trim()).FirstOrDefault();
            notification.Status = "Closed";
            eqApproval.status = (PassedData == "Declined") ? "Declined" : (PassedData == "Approved") ? "Approved" : "Ok";
            string action = eqApproval.ApprovalType;
            string originId = eqApproval.OriginRolePersonel;
            string actionbody = (eqApproval.status == "Declined") ? "Your request was declined" : "Your request was approved";
            string datetime = notification.DateandTime;
            await _notificationsService.Update(notification);
            await _approvalsRepository.UpdateApproval(eqApproval);
            string date = string.Format("{0}/{1}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            string time = string.Format("{0}:{1}", DateTime.Now.TimeOfDay.Hours, DateTime.Now.TimeOfDay.Minutes);
            var RespectiveNotification = new Notification()
            {
                NameHeader = "Response on your request to " + action + " on " + datetime,
                Body = actionbody,
                Department = eqApproval.OriginRole,
                Status = "Opened",
                ConsumerId = originId,
                DateandTime = string.Format("Date : {0} : {1}", date, time),
                Type = "Feedback"
            };
            var responsestream = RespectiveNotification;
            await _notificationsService.Add(RespectiveNotification);
            return Json(responsestream);
        }
        public JsonResult PopulateMenuItem(string gid)
        {
            int Pid = 0;
            int.TryParse(gid, out Pid);
            IEnumerable<Item> LocalMenuGrouping = _context.Items.Where(a => a.ClassificationId == Pid).Distinct();
            //return new JsonResult(new{ Data = LocalMenuGrouping }) ;
            return Json(LocalMenuGrouping);
        }
    }
}

