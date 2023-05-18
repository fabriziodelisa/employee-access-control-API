using personnel_access_control.Entities;
using personnel_access_control.Models;

namespace personnel_access_control.Repositories
{
    public interface IAccessRepository
    { 
        public bool AccessRegister(Access AccessData);
        public SearchResponseDto Search(DateTime dateFrom, DateTime dateTo, string? descriptionFilter, int companyBranchId);
    }
}
