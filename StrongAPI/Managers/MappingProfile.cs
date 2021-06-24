using AutoMapper;
using StrongAPI.DataTransferObjects;
using StrongAPI.Models;

namespace StrongAPI.Managers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
