using AutoMapper;
using AutoMapperExample.Dto;

namespace AutoMapperExample
{
    public class HeroProfile:Profile
    {
        public HeroProfile()
        {
            CreateMap<SuperHero, SuperHeroDto>().ReverseMap();
        }
    }
}
