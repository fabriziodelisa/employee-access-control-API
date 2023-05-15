using personnel_access_control.enums;
using System.ComponentModel.DataAnnotations;

namespace personnel_access_control.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public Genders Gender { get; set; }
    }
}
