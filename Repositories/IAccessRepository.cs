using personnel_access_control.Entities;

namespace personnel_access_control.Repositories
{
    public interface IAccessRepository
    { 
        public bool AccessRegister(Access AccessData);
    }
}
