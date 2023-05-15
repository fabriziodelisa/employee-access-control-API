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
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Delfina",
                    LastName = "Torres",
                    Gender = enums.Genders.Female,
                },
                new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Bianca",
                    LastName = "Perez",
                    Gender = enums.Genders.Female,
                }
            );

            modelBuilder.Entity<CompanyBranch>().HasData(
                new CompanyBranch
                {
                    CompanyBranchId = 1,
                    Location = "Argentina",
                },
                new CompanyBranch
                {
                    CompanyBranchId = 2,
                    Location = "Brasil",
                },
                new CompanyBranch
                {
                    CompanyBranchId = 3,
                    Location = "España",
                }
           );

            base.OnModelCreating(modelBuilder);

        }
    }
}
