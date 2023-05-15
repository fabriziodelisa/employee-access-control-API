using personnel_access_control.enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personnel_access_control.Entities
{
    public class Access
    {
        [Key]
        public int AccessId { get; set; }
        [Required]
        public DateTime AccessDateTime { get; set; }
        [Required]
        public AccessType AccessType { get; set; }

        [Required]
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        [ForeignKey("CompanyBranch")]
        public int CompanyBranchId { get; set; }
        public CompanyBranch CompanyBranch { get; set; }
    }
}
