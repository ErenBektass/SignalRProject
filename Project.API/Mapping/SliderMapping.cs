using AutoMapper;
using Project.DTO.SliderDto;
using Project.ENTITIES.Models;

namespace Project.API.Mapping
{
    public class SliderMapping : Profile
    {
        public SliderMapping()
        {
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
        }
    }
}
