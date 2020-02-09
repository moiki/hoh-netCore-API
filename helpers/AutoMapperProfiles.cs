using AutoMapper;
using hohsys.API.dtos;
using hohsys.API.models;

namespace hohsys.API.helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForDetailsDto>().ReverseMap();
            CreateMap<User, RegistrationUserDto>().ReverseMap();
        }
    }
}