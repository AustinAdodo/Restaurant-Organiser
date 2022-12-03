using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Restaurant_Menu_Organiser.Data;
using Restaurant_Menu_Organiser.Models.Approvals;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Restaurant_Menu_Organiser.Utilities.Services;
using Restaurant_Menu_Organiser.Repositories;
using Restaurant_Menu_Organiser.Models.Notifications;
using Microsoft.AspNetCore.Routing;
using Restaurant_Menu_Organiser.ViewModels;

namespace Restaurant_Menu_Organiser.Utilities
{
    public abstract class ApprovalRequiredForActionBase : ActionFilterAttribute
    {
        public string RequestingRoles { get; set; }
        public string Action { get; set; }
        public string SuperiorRoles { get; set; }
        public object PassedParams { get; set; }
        public string Id { get; set; }
    }
    public class ApprovalRequiredForAction : ApprovalRequiredForActionBase, IActionFilter
    {
        public ApprovalRequiredForAction()
        { }
        public override void OnActionExecuted(ActionExecutedContext _actioncontext)
        { }
        public override void OnActionExecuting(ActionExecutingContext _actioncontext)
        {
            IUserPreferencesServices _userPreferencesServices = (IUserPreferencesServices)_actioncontext.HttpContext.RequestServices.GetService(typeof(IUserPreferencesServices));
            INotificationsService _notificationsService = (INotificationsService)_actioncontext.HttpContext.RequestServices.GetService(typeof(INotificationsService));
            UserManager<IdentityUser> _userManager = (UserManager<IdentityUser>)_actioncontext.HttpContext.RequestServices.GetService(typeof(UserManager<IdentityUser>));
            Id = _actioncontext.ActionArguments["id"].ToString();
            string UserId = (Action == "Edit Employee") ? _userPreferencesServices.GetloggedInUserId() : _actioncontext.ActionArguments["UserId"].ToString();
            var DeployedModel = ((string)_actioncontext.RouteData.Values["Action"] == "Edit") ? _actioncontext.ActionArguments["model"] :
                ((string)_actioncontext.RouteData.Values["Action"] == "Create") ? _actioncontext.ActionArguments["model"] : null;
            var thisUser = _userManager.FindByIdAsync(UserId).Result;
            if (!_userManager.IsInRoleAsync(thisUser, RequestingRoles).Result)
            { return; }
            bool Result = _userPreferencesServices.ExecuteApproval(RequestingRoles, Action, Id, DeployedModel).Result;
            if (Result == true)
            {
                _actioncontext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "Controller", "Home" }, { "Action", "Activity" } });
            }
            if (Result == false)
            {
                string Failedmsg = UserPreferencesServices.FailedStatusMessage();
                string date = string.Format("{0}/{1}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                string time = string.Format("{0}:{1}", DateTime.Now.TimeOfDay.Hours, DateTime.Now.TimeOfDay.Minutes);
                var RespectiveNotification1 = new Notification()
                {
                    NameHeader = "Failure",
                    Body = Failedmsg,
                    Department = RequestingRoles,
                    Status = "Opened",
                    Type = "Feedback",
                    DateandTime = string.Format("Date : {0},at : {1}", date, time),
                    ConsumerId = UserId
                };
                ////In the event of failure
                _notificationsService.Add(RespectiveNotification1);
                _actioncontext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "Controller", "Home" }, { "Action", "Activity" } });
            }

        }
    }
}
/////System.Web.Http.Controllers.HttpActionContext.
////.......................Retrieve current logged in UserId Using the HttpContext
//base.AuthenticationSchemes;_actioncontext.Result = new RedirectResult("/Home/Activities");
/*this.UserID = _userManager.GetUserId(_httpcontext.User); */  //base.AuthenticationSchemes;
