using AutoMapper;
using AutoMapperExample.Dto;
using AutoMapperExample.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperExample.Services.Concrete
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly IMapper _mapper;

        public SuperHeroService(IMapper mapper)
        {
            _mapper = mapper;
        }

        private static List<SuperHero> heroes = new List<SuperHero>()
        {
            new SuperHero
            {
                Id=1,
                Name="Spider Man",
                FirstName="Peter",
                LastName="Parker",
                Place="New York City",
                DateAdded= new DateTime(2001,08,10),
                DateModified=null
            },
             new SuperHero
            {
                Id=1,
                Name="Iron Man",
                FirstName="Tony",
                LastName="Stark",
                Place="Malibu",
                DateAdded= new DateTime(1970,05,29),
                DateModified=null
            }
        };
        public IQueryable<SuperHeroDto> GetHeroes()
        {
            return _mapper.ProjectTo<SuperHeroDto>(heroes.AsQueryable());
        }
    }
}
