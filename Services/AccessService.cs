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

        public bool AccessRegister(RegisterAccessDto registerAccessDto)
        {
            var accessData = _mapper.Map<Access>(registerAccessDto);
            var successfulReg = _accessRepository.AccessRegister(accessData);
            return successfulReg;
        }

        public SearchResponseDto Search(DateTime dateFrom, DateTime dateTo, string? descriptionFilter, int companyBranchId)
        {
            if (dateTo > DateTime.Now)
            {
                throw new ArgumentException("Invalid date provided. The end date cannot be greater than the current date.");
            }

            if (dateTo == DateTime.MinValue)
            {
                dateTo = DateTime.Now;
            }

            if (dateFrom > dateTo)
            {
                throw new ArgumentException("Invalid dates provided. The start date cannot be greater than the end date.");
            }

            var response = _accessRepository.Search(dateFrom, dateTo, descriptionFilter, companyBranchId);
            return response;
        }
    }
}
