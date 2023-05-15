using AutoMapper;
using personnel_access_control.Entities;
using personnel_access_control.Models;
using personnel_access_control.Repositories;

namespace personnel_access_control.Services
{
    public class AccessService : IAccessService
    {
        private readonly IMapper _mapper;
        private readonly IAccessRepository _accessRepository;

        public AccessService(IMapper mapper, IAccessRepository accessRepository)
        {
            _mapper = mapper;
            _accessRepository = accessRepository;
        }

        public bool AccessRegister(RegisterAccessDto AccesData)
        {
            var accessData = _mapper.Map<Access>(AccesData);
            var SuccessfulReg = _accessRepository.AccessRegister(accessData);
            return SuccessfulReg;
        }
    }
}
