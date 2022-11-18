using AutoMapper;
using StudentAdminPortal.API.DomainModels;
using Models=StudentAdminPortal.API.Models;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Models.Student, Student>()
            .ReverseMap();

            CreateMap<Models.Gender, Gender>()
           .ReverseMap();

            CreateMap<Models.Address, Address>()
           .ReverseMap();
        }
    }
}
