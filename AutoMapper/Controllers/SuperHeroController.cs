using AutoMapperExample.Dto;
using AutoMapperExample.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public ActionResult<IQueryable<SuperHeroDto>> GetHeroes()
        {
            var entity = _superHeroService.GetHeroes();
            return Ok(entity);
        }
    }
}
