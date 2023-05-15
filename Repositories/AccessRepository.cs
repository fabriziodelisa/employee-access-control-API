using personnel_access_control.DbContexts;
using personnel_access_control.Entities;

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
    }
}
