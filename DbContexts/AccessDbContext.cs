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
                },
                new Employee
                {
                    EmployeeId = 4,
                    FirstName = "Juan",
                    LastName = "Gonzalez",
                    Gender = enums.Genders.Male,
                },
                new Employee
                {
                    EmployeeId = 5,
                    FirstName = "Sofia",
                    LastName = "Lopez",
                    Gender = enums.Genders.Female,
                },
                new Employee
                {
                    EmployeeId = 6,
                    FirstName = "Diego",
                    LastName = "Fernandez",
                    Gender = enums.Genders.Male,
                },
                new Employee
                {
                    EmployeeId = 7,
                    FirstName = "Valentina",
                    LastName = "Silva",
                    Gender = enums.Genders.Female,
                },
                new Employee
                {
                    EmployeeId = 8,
                    FirstName = "Mateo",
                    LastName = "Hernandez",
                    Gender = enums.Genders.Male,
                },
                new Employee
                {
                    EmployeeId = 9,
                    FirstName = "Isabella",
                    LastName = "Gomez",
                    Gender = enums.Genders.Female,
                },
                new Employee
                {
                    EmployeeId = 10,
                    FirstName = "Martin",
                    LastName = "Pereira",
                    Gender = enums.Genders.Male,
                },
                new Employee
                {
                    EmployeeId = 11,
                    FirstName = "Camila",
                    LastName = "Rojas",
                    Gender = enums.Genders.Female,
                },
                new Employee
                {
                    EmployeeId = 12,
                    FirstName = "Joaquin",
                    LastName = "Luna",
                    Gender = enums.Genders.Male,
                },
                new Employee
                {
                    EmployeeId = 13,
                    FirstName = "Mia",
                    LastName = "Fuentes",
                    Gender = enums.Genders.Female,
                },
                new Employee
                {
                    EmployeeId = 14,
                    FirstName = "Facundo",
                    LastName = "Mendoza",
                    Gender = enums.Genders.Male,
                },
                new Employee
                {
                    EmployeeId = 15,
                    FirstName = "Valeria",
                    LastName = "Castillo",
                    Gender = enums.Genders.Female,
                },
                new Employee
                {
                    EmployeeId = 16,
                    FirstName = "Ignacio",
                    LastName = "Navarro",
                    Gender = enums.Genders.Male,
                },
                new Employee
                {
                    EmployeeId = 17,
                    FirstName = "Luz",
                    LastName = "Santos",
                    Gender = enums.Genders.Female,
                },
                new Employee
                {
                    EmployeeId = 18,
                    FirstName = "Emilio",
                    LastName = "Paz",
                    Gender = enums.Genders.Male,
                },
                new Employee
                {
                    EmployeeId = 19,
                    FirstName = "Catalina",
                    LastName = "Cardenas",
                    Gender = enums.Genders.Female,
                },
                new Employee
                {
                    EmployeeId = 20,
                    FirstName = "Sebastian",
                    LastName = "Ramos",
                    Gender = enums.Genders.Male,
                }
            );


            modelBuilder.Entity<Access>().HasData(
                new Access
                {
                    AccessId = 30,
                    AccessDateTime = new DateTime(2022, 6, 1),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 1,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 31,
                    AccessDateTime = new DateTime(2022, 4, 15),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 5,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 32,
                    AccessDateTime = new DateTime(2022, 8, 20),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 10,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 33,
                    AccessDateTime = new DateTime(2022, 6, 12),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 3,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 34,
                    AccessDateTime = new DateTime(2022, 7, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 7,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 35,
                    AccessDateTime = new DateTime(2022, 6, 25),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 15,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 36,
                    AccessDateTime = new DateTime(2022, 9, 8),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 12,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 37,
                    AccessDateTime = new DateTime(2022, 2, 28),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 18,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 38,
                    AccessDateTime = new DateTime(2022, 10, 16),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 6,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 39,
                    AccessDateTime = new DateTime(2022, 3, 10),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 9,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 40,
                    AccessDateTime = new DateTime(2022, 7, 15),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 18,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 41,
                    AccessDateTime = new DateTime(2022, 12, 3),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 4,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 42,
                    AccessDateTime = new DateTime(2022, 9, 21),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 15,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 43,
                    AccessDateTime = new DateTime(2022, 5, 10),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 8,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 44,
                    AccessDateTime = new DateTime(2022, 11, 27),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 9,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 45,
                    AccessDateTime = new DateTime(2022, 2, 8),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 13,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 46,
                    AccessDateTime = new DateTime(2022, 1, 4),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 1,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 47,
                    AccessDateTime = new DateTime(2022, 8, 7),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 5,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 48,
                    AccessDateTime = new DateTime(2022, 7, 18),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 10,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 49,
                    AccessDateTime = new DateTime(2022, 3, 29),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 20,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 50,
                    AccessDateTime = new DateTime(2022, 9, 5),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 3,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 51,
                    AccessDateTime = new DateTime(2022, 8, 11),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 17,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 52,
                    AccessDateTime = new DateTime(2022, 3, 16),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 11,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 53,
                    AccessDateTime = new DateTime(2022, 6, 29),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 12,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 54,
                    AccessDateTime = new DateTime(2022, 4, 24),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 16,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 55,
                    AccessDateTime = new DateTime(2022, 11, 2),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 7,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 56,
                    AccessDateTime = new DateTime(2022, 4, 2),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 19,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 57,
                    AccessDateTime = new DateTime(2022, 2, 12),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 6,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 58,
                    AccessDateTime = new DateTime(2022, 10, 23),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 14,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 59,
                    AccessDateTime = new DateTime(2022, 1, 20),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 2,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 60,
                    AccessDateTime = new DateTime(2022, 10, 8),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 8,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 61,
                    AccessDateTime = new DateTime(2022, 3, 15),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 6,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 62,
                    AccessDateTime = new DateTime(2022, 2, 28),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 19,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 63,
                    AccessDateTime = new DateTime(2022, 1, 10),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 13,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 64,
                    AccessDateTime = new DateTime(2022, 9, 5),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 14,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 65,
                    AccessDateTime = new DateTime(2022, 8, 27),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 20,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 66,
                    AccessDateTime = new DateTime(2022, 12, 1),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 8,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 67,
                    AccessDateTime = new DateTime(2022, 11, 16),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 4,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 68,
                    AccessDateTime = new DateTime(2022, 3, 18),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 1,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 69,
                    AccessDateTime = new DateTime(2022, 7, 22),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 10,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 70,
                    AccessDateTime = new DateTime(2022, 2, 8),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 5,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 71,
                    AccessDateTime = new DateTime(2022, 4, 15),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 11,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 72,
                    AccessDateTime = new DateTime(2022, 1, 3),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 17,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 73,
                    AccessDateTime = new DateTime(2022, 10, 20),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 15,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 74,
                    AccessDateTime = new DateTime(2022, 9, 12),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 12,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 75,
                    AccessDateTime = new DateTime(2022, 6, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 7,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 76,
                    AccessDateTime = new DateTime(2022, 11, 30),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 9,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 77,
                    AccessDateTime = new DateTime(2022, 2, 10),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 16,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 78,
                    AccessDateTime = new DateTime(2022, 12, 23),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 3,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 79,
                    AccessDateTime = new DateTime(2022, 5, 19),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 18,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 80,
                    AccessDateTime = new DateTime(2022, 3, 5),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 2,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 81,
                    AccessDateTime = new DateTime(2022, 10, 10),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 12,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 82,
                    AccessDateTime = new DateTime(2022, 2, 28),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 19,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 83,
                    AccessDateTime = new DateTime(2022, 1, 15),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 5,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 84,
                    AccessDateTime = new DateTime(2022, 8, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 11,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 85,
                    AccessDateTime = new DateTime(2022, 7, 27),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 17,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 86,
                    AccessDateTime = new DateTime(2022, 12, 10),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 6,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 87,
                    AccessDateTime = new DateTime(2022, 11, 16),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 3,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 88,
                    AccessDateTime = new DateTime(2022, 4, 18),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 9,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 89,
                    AccessDateTime = new DateTime(2022, 7, 25),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 20,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 90,
                    AccessDateTime = new DateTime(2022, 3, 8),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 14,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 91,
                    AccessDateTime = new DateTime(2022, 4, 10),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 18,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 92,
                    AccessDateTime = new DateTime(2022, 1, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 4,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 93,
                    AccessDateTime = new DateTime(2022, 11, 20),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 7,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 94,
                    AccessDateTime = new DateTime(2022, 10, 12),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 16,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 95,
                    AccessDateTime = new DateTime(2022, 2, 28),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 2,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 96,
                    AccessDateTime = new DateTime(2022, 12, 15),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 10,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 97,
                    AccessDateTime = new DateTime(2022, 4, 5),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 15,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 98,
                    AccessDateTime = new DateTime(2022, 3, 10),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 8,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 99,
                    AccessDateTime = new DateTime(2022, 9, 18),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 13,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 100,
                    AccessDateTime = new DateTime(2022, 8, 27),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 19,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 101,
                    AccessDateTime = new DateTime(2022, 7, 10),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 14,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 102,
                    AccessDateTime = new DateTime(2022, 1, 28),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 20,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 103,
                    AccessDateTime = new DateTime(2022, 11, 15),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 6,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 104,
                    AccessDateTime = new DateTime(2022, 8, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 10,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 105,
                    AccessDateTime = new DateTime(2022, 6, 27),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 17,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 106,
                    AccessDateTime = new DateTime(2022, 12, 10),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 5,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 107,
                    AccessDateTime = new DateTime(2022, 10, 16),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 1,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 108,
                    AccessDateTime = new DateTime(2022, 4, 18),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 19,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 109,
                    AccessDateTime = new DateTime(2022, 7, 25),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 2,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 110,
                    AccessDateTime = new DateTime(2022, 3, 8),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 16,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 111,
                    AccessDateTime = new DateTime(2022, 4, 10),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 18,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 112,
                    AccessDateTime = new DateTime(2022, 1, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 3,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 113,
                    AccessDateTime = new DateTime(2022, 11, 20),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 7,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 114,
                    AccessDateTime = new DateTime(2022, 10, 12),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 16,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 115,
                    AccessDateTime = new DateTime(2022, 3, 28),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 12,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 116,
                    AccessDateTime = new DateTime(2022, 9, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 9,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 117,
                    AccessDateTime = new DateTime(2022, 7, 18),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 13,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 118,
                    AccessDateTime = new DateTime(2022, 5, 10),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 4,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 119,
                    AccessDateTime = new DateTime(2022, 2, 25),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 11,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 120,
                    AccessDateTime = new DateTime(2022, 1, 15),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 8,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 121,
                    AccessDateTime = new DateTime(2022, 9, 18),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 15,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 122,
                    AccessDateTime = new DateTime(2022, 3, 5),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 2,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 123,
                    AccessDateTime = new DateTime(2022, 8, 20),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 5,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 124,
                    AccessDateTime = new DateTime(2022, 10, 10),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 8,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 125,
                    AccessDateTime = new DateTime(2022, 5, 27),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 19,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 126,
                    AccessDateTime = new DateTime(2022, 12, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 10,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 127,
                    AccessDateTime = new DateTime(2022, 11, 16),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 12,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 128,
                    AccessDateTime = new DateTime(2022, 5, 18),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 16,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 129,
                    AccessDateTime = new DateTime(2022, 9, 25),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 1,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 130,
                    AccessDateTime = new DateTime(2022, 4, 8),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 18,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 131,
                    AccessDateTime = new DateTime(2022, 4, 10),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 20,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 132,
                    AccessDateTime = new DateTime(2022, 2, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 3,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 133,
                    AccessDateTime = new DateTime(2022, 12, 20),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 6,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 134,
                    AccessDateTime = new DateTime(2022, 11, 12),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 16,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 135,
                    AccessDateTime = new DateTime(2022, 2, 15),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 7,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 136,
                    AccessDateTime = new DateTime(2022, 7, 28),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 14,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 137,
                    AccessDateTime = new DateTime(2022, 4, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 4,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 138,
                    AccessDateTime = new DateTime(2022, 6, 10),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 17,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 139,
                    AccessDateTime = new DateTime(2022, 1, 28),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 9,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 140,
                    AccessDateTime = new DateTime(2022, 8, 12),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 13,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 141,
                    AccessDateTime = new DateTime(2022, 10, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 5,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 142,
                    AccessDateTime = new DateTime(2022, 2, 20),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 17,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 143,
                    AccessDateTime = new DateTime(2022, 12, 15),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 9,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 144,
                    AccessDateTime = new DateTime(2022, 8, 10),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 3,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 145,
                    AccessDateTime = new DateTime(2022, 4, 27),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 16,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 146,
                    AccessDateTime = new DateTime(2022, 11, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 8,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 147,
                    AccessDateTime = new DateTime(2022, 1, 16),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 12,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 148,
                    AccessDateTime = new DateTime(2022, 5, 18),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 1,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 149,
                    AccessDateTime = new DateTime(2022, 9, 25),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 19,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 150,
                    AccessDateTime = new DateTime(2022, 5, 8),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 18,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 151,
                    AccessDateTime = new DateTime(2022, 5, 10),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 20,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 152,
                    AccessDateTime = new DateTime(2022, 3, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 2,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 153,
                    AccessDateTime = new DateTime(2022, 11, 20),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 6,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 154,
                    AccessDateTime = new DateTime(2022, 11, 12),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 16,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 155,
                    AccessDateTime = new DateTime(2022, 7, 8),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 13,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 156,
                    AccessDateTime = new DateTime(2022, 3, 27),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 15,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 157,
                    AccessDateTime = new DateTime(2022, 12, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 11,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 158,
                    AccessDateTime = new DateTime(2022, 2, 16),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 10,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 159,
                    AccessDateTime = new DateTime(2022, 6, 18),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 7,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 160,
                    AccessDateTime = new DateTime(2022, 10, 25),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 9,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 161,
                    AccessDateTime = new DateTime(2022, 6, 8),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 5,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 181,
                    AccessDateTime = new DateTime(2022, 7, 10),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 6,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 182,
                    AccessDateTime = new DateTime(2022, 1, 25),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 9,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 183,
                    AccessDateTime = new DateTime(2022, 10, 15),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 17,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 184,
                    AccessDateTime = new DateTime(2022, 6, 20),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 13,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 185,
                    AccessDateTime = new DateTime(2022, 3, 31),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 19,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 186,
                    AccessDateTime = new DateTime(2022, 8, 5),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 15,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 187,
                    AccessDateTime = new DateTime(2022, 2, 16),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 10,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 188,
                    AccessDateTime = new DateTime(2022, 4, 30),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 4,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 189,
                    AccessDateTime = new DateTime(2022, 9, 21),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 8,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 190,
                    AccessDateTime = new DateTime(2022, 5, 6),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 18,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 191,
                    AccessDateTime = new DateTime(2022, 5, 15),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 14,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 192,
                    AccessDateTime = new DateTime(2022, 3, 2),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 2,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 193,
                    AccessDateTime = new DateTime(2022, 11, 25),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 7,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 194,
                    AccessDateTime = new DateTime(2022, 11, 8),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 16,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 195,
                    AccessDateTime = new DateTime(2022, 2, 16),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 12,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 196,
                    AccessDateTime = new DateTime(2022, 12, 1),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 20,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 197,
                    AccessDateTime = new DateTime(2022, 10, 10),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 3,
                    CompanyBranchId = 1
                },
                new Access
                {
                    AccessId = 198,
                    AccessDateTime = new DateTime(2022, 1, 21),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 6,
                    CompanyBranchId = 2
                },
                new Access
                {
                    AccessId = 199,
                    AccessDateTime = new DateTime(2022, 9, 12),
                    AccessType = enums.AccessType.entry,
                    EmployeeId = 17,
                    CompanyBranchId = 3
                },
                new Access
                {
                    AccessId = 200,
                    AccessDateTime = new DateTime(2022, 7, 2),
                    AccessType = enums.AccessType.exit,
                    EmployeeId = 13,
                    CompanyBranchId = 1
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
