using AutoMapperExample.Dto;

namespace AutoMapperExample.Services.Abstract
{
    public interface ISuperHeroService
    {
        IQueryable<SuperHeroDto> GetHeroes();
    }
}
