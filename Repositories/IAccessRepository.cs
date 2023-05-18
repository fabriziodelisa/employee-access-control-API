using personnel_access_control.Entities;
using personnel_access_control.Models;

namespace personnel_access_control.Repositories
{
    public interface IAccessRepository
    {
        public bool AccessRegister(Access AccessData);
        public SearchDto Search(DateTime dateFrom, DateTime dateTo, string? descriptionFilter, int companyBranchId);
        public AverageDto Average(DateTime dateFrom, DateTime dateTo);
        public bool CompanyBranchExist(int companyBranchId);
        public bool EmployeeExist(int employeeId);
    }
}
