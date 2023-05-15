using AutoMapper;
using personnel_access_control.Entities;
using personnel_access_control.Models;

namespace personnel_access_control.AutoMapperProfiles
{
    public class AccessProfile : Profile
    {
        public AccessProfile()
        {
            CreateMap<RegisterAccessDto, Access>();
        }
    }
}
