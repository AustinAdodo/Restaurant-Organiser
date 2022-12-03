using Restaurant_Menu_Organiser.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Models.Approvals
{
    public class DBApprovalsImplementations : IApprovalsRepository
    {
        private readonly ApplicationDbContext _approvalContext;

        public DBApprovalsImplementations(ApplicationDbContext approvalContext)
        {
            _approvalContext = approvalContext;
        }
        public async Task<Approval> AddNewApproval(Approval approval)
        {
            _approvalContext.Add(approval);
            await _approvalContext.SaveChangesAsync();
            return approval;
        }
        public Approval GetApproval(int id)
        {
            return _approvalContext.Approvals.Find(id);
        }
        public async Task<Approval> UpdateApproval(Approval approvalChanges)
        {
            var EditedEmployee = _approvalContext.Approvals.Attach(approvalChanges);
            EditedEmployee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _approvalContext.SaveChangesAsync();
            return approvalChanges;
        }
        //public async Task<Approval> Update(Approval approvalChanges)
        //{
        //    var editedApproval = _approvalContext.Approvals.Attach(approvalChanges);
        //    editedApproval.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    await _approvalContext.SaveChangesAsync();
        //    return approvalChanges;
        //}
        public int Getcount()
        {
            return _approvalContext.Approvals.Count();
        }
    }
}
