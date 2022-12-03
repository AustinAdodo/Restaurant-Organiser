using Microsoft.AspNetCore.Identity;
using Restaurant_Menu_Organiser.Models.Approvals;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Utilities.Services
{
    public interface IUserPreferencesServices
    {
        public Task<IdentityUser> User { get; }
        public Task<bool> ExecuteApproval(string RequestingRoles, string Action, string Id, object model);
        public Task<bool> IsInRole(string role);
        public Task<IdentityUser> GetloggedInUser();
        //public string GetCurrentActionParameters();
        public string GetloggedInUserId();
        public bool IsAuthenticated();
    }
}