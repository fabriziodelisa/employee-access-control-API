using personnel_access_control.Models;

namespace personnel_access_control.Services
{
    public interface IAccessService
    {
        public bool AccessRegister(RegisterAccessDto AccesData);
        public SearchResponseDto Search(DateTime dateFrom, DateTime dateTo, string? descriptionFilter, int companyBranchId);
    }
}
