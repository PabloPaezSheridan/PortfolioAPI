using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Entities;
using PortfolioAPI.Models;
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
            return Ok(ExperienceRepository.Experiences);
        }

        [HttpGet("{titleForSearch}")]
        public IActionResult Get(string titleForSearch)
        {
            return Ok(ExperienceRepository.Experiences.Where(e => e.Title.Contains(titleForSearch)));
        }

        [HttpPost]
        public IActionResult AddExperience([FromBody]ExperienceForCreationRequest requestdto)
        {
            Experience experience = new Experience()
            {
                Description = requestdto.Description,
                Title = requestdto.Title,
                ImagePath = requestdto.ImagePath,
                Summary = "En proceso"
            };
            ExperienceRepository.Experiences.Add(experience);

            return Ok(ExperienceRepository.Experiences);
        }
    }
}
