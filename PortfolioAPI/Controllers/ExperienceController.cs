using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Entities;
using PortfolioAPI.Repositories;

namespace PortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            ExperienceRepository experienceRepository = new ExperienceRepository();
            List<Experience> experiences = experienceRepository.Experiences;
            return Ok(experiences);
        }

        [HttpGet("{titleForSearch}")]
        public IActionResult Get(string titleForSearch)
        {
            ExperienceRepository experienceRepository = new ExperienceRepository();
            List<Experience> experiences = experienceRepository.Experiences;
            return Ok(experiences.Where(e => e.Title.Contains(titleForSearch)));
        }
    }
}
