using Microsoft.EntityFrameworkCore;
using personnel_access_control.DbContexts;
using personnel_access_control.Entities;
using personnel_access_control.Models;

namespace personnel_access_control.Repositories
{
    public class AccessRepository : IAccessRepository
    {
        internal readonly AccessDbContext _AccessDbContext;

        public AccessRepository(AccessDbContext context)
        {
            _AccessDbContext = context;
        }


        public bool AccessRegister(Access AccessData)
        {
            _AccessDbContext.Accesses.Add(AccessData);
            bool successfulReg = _AccessDbContext.SaveChanges() >= 0;
            return successfulReg;
        }

        public SearchDto Search(DateTime dateFrom, DateTime dateTo, string? descriptionFilter, int companyBranchId)
        {
            var accessList = _AccessDbContext.Accesses
                .Include(a => a.Employee)
                .Where(a => a.AccessDateTime >= dateFrom && a.AccessDateTime <= dateTo)
                .ToList();

            if (!string.IsNullOrWhiteSpace(descriptionFilter))
            {
                accessList = accessList.Where(a =>
                a.Employee.LastName.Equals(descriptionFilter, StringComparison.OrdinalIgnoreCase) ||
                a.Employee.FirstName.Equals(descriptionFilter, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (companyBranchId != 0)
            {
                accessList = accessList.Where(a => a.CompanyBranchId == companyBranchId).ToList();
            }

            var entries = accessList.Where(a => a.AccessType == enums.AccessType.entry).Count();
            var exits = accessList.Where(a => a.AccessType == enums.AccessType.exit).Count();

            var response = new SearchDto
            {
                Entries = entries,
                Exits = exits
            };
            return response;
        }


        public AverageDto Average(DateTime dateFrom, DateTime dateTo)
        {
            int differenceInMonth = (dateTo.Year - dateFrom.Year) * 12 + dateTo.Month - dateFrom.Month;
            var averagebyGender = _AccessDbContext.Accesses
               .Include(a => a.Employee)
               .Include(a => a.CompanyBranch)
               .Where(a => a.AccessDateTime >= dateFrom && a.AccessDateTime <= dateTo)
               .GroupBy(a => a.CompanyBranch.Location)
               .Select(branch => new
               {
                   CompanyBranchId = branch.Key,
                   Genders = branch.GroupBy(b => b.Employee.Gender)
                                    .Select(gender => new
                                    {
                                        Gender = gender.Key.ToString(),
                                        numOfEntryExit = Math.Round(((decimal)gender.Count() / differenceInMonth))
                                    })
               });
            return new AverageDto { AverageByGender = averagebyGender };
        }

        public bool CompanyBranchExist(int companyBranchId)
        {
            return _AccessDbContext.CompanyBranches.Any(b => b.CompanyBranchId == companyBranchId);
        }

        public bool EmployeeExist(int employeeId)
        {
            return _AccessDbContext.Employees.Any(b => b.EmployeeId == employeeId);
        }
    }
}
