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
            return _AccessDbContext.SaveChanges() >= 0;
        }

        public SearchResponseDto Search(DateTime dateFrom, DateTime dateTo, string? descriptionFilter, int companyBranchId)
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

            var response = new SearchResponseDto
            {
                Entries = entries,
                Exits = exits
            };

            return response;
        }
    }
}
