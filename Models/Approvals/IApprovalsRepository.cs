using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Menu_Organiser.Models.Approvals
{
    public interface IApprovalsRepository
    {
        public Task<Approval> AddNewApproval(Approval approval);
        public Approval GetApproval(int id);
        public Task<Approval> UpdateApproval(Approval approvalChanges);
        public int Getcount();
    }
}
