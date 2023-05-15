using Microsoft.EntityFrameworkCore;
using personnel_access_control.Entities;

namespace personnel_access_control.DbContexts
{
    public class AccessDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CompanyBranch> CompanyBranches { get; set; }
        public DbSet<Access> Accesses { get; set; }

        public AccessDbContext(DbContextOptions<AccessDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                   EmployeeId = 1,
                   FirstName = "Lucas",
                   LastName = "Rodriguez",
                   Gender = enums.Genders.Male,
                }
            );

            base.OnModelCreating(modelBuilder);

        }
    }
}
