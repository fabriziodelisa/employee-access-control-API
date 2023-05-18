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


        public void AccessRegister(RegisterAccessDto registerAccessDto)
        {
            if(!_accessRepository.EmployeeExist(registerAccessDto.EmployeeId)) 
            {
                throw new ArgumentException("Employee ID doesn't exist.");
            }

            if (!_accessRepository.CompanyBranchExist(registerAccessDto.CompanyBranchId))
            {
                throw new ArgumentException("Company Branch ID doesn't exist.");
            }

            var accessData = _mapper.Map<Access>(registerAccessDto);
            var successfulReg = _accessRepository.AccessRegister(accessData);

            if (!successfulReg)
            {
                throw new ArgumentException("An error occurred while saving changes.");
            }
        }


        public SearchDto Search(DateTime dateFrom, DateTime dateTo, string? descriptionFilter, int companyBranchId)
        {
            dateTo = ValidateDateRange(dateFrom, dateTo);
            if (companyBranchId != 0 && !_accessRepository.CompanyBranchExist(companyBranchId))
            {
                throw new ArgumentException("Company Branch ID doesn't exist.");
            }
            var response = _accessRepository.Search(dateFrom, dateTo, descriptionFilter, companyBranchId);
            return response;
        }


        public AverageDto Average(DateTime dateFrom, DateTime dateTo)
        {
            dateTo = ValidateDateRange(dateFrom, dateTo);
            var response = _accessRepository.Average(dateFrom, dateTo);
            return response;
        }


        private DateTime ValidateDateRange(DateTime dateFrom, DateTime dateTo)
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
            return dateTo;
        }
    }
}
