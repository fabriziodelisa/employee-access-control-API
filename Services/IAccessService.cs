using personnel_access_control.Models;

namespace personnel_access_control.Services
{
    public interface IAccessService
    {
        public void AccessRegister(RegisterAccessDto registerAccessDto);
        public SearchDto Search(DateTime dateFrom, DateTime dateTo, string? descriptionFilter, int companyBranchId);
        public AverageDto Average(DateTime dateFrom, DateTime dateTo);
    }
}
