using System.ComponentModel.DataAnnotations;

namespace personnel_access_control.Entities
{
    public class CompanyBranch
    {
        [Key]
        public int CompanyBranchId { get; set; }
        [Required]
        public string Location { get; set; } = string.Empty;
    }
}
