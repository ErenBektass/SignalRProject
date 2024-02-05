using AutoMapper;
using Project.DTO.AboutDto;
using Project.ENTITIES.Models;

namespace Project.API.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
                CreateMap<About, ResultAboutDto>().ReverseMap();
                CreateMap<About, CreateAboutDto>().ReverseMap();
                CreateMap<About, GetAboutDto>().ReverseMap();
                CreateMap<About, UpdateAboutDto>().ReverseMap();
        }
    }
}
