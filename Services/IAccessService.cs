using personnel_access_control.Models;

namespace personnel_access_control.Services
{
    public interface IAccessService
    {
        public bool AccessRegister(RegisterAccessDto AccesData);
    }
}
