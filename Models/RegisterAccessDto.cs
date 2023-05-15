using personnel_access_control.enums;

namespace personnel_access_control.Models
{
    public class RegisterAccessDto
    {
        public DateTime AccessDateTime { get; set; }
        public AccessType AccessType { get; set; }
        public int EmployeeId { get; set; }
        public int CompanyBranchId {get; set; }
    }
}
