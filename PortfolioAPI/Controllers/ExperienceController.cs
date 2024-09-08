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
        public IActionResult Get([FromQuery] bool includeDeleted = false)
        {
            if (includeDeleted)
            {
                return Ok(ExperienceRepository.Experiences);
            }
            else
            {    
                return Ok(ExperienceRepository.Experiences.Where(e => e.State == "Active"));
            }
        }

        [HttpGet("{titleForSearch}")]
        public IActionResult Get(string titleForSearch)
        {
            return Ok(ExperienceRepository.Experiences.Where(e => e.Title.Contains(titleForSearch)));
        }

        [HttpPost]
        public IActionResult AddExperience([FromBody] ExperienceForCreationAndUpdateRequest requestdto)
        {
            Experience experience = new Experience()
            {
                Id = ExperienceRepository.Experiences.Count()+1,
                Description = requestdto.Description,
                Title = requestdto.Title,
                ImagePath = requestdto.ImagePath,
                Summary = "En proceso"
            };
            ExperienceRepository.Experiences.Add(experience);

            return Ok(ExperienceRepository.Experiences);
        }
        [HttpPut("{idExperience}")]
        public IActionResult Update([FromRoute]int idExperience, [FromBody] ExperienceForCreationAndUpdateRequest requestDto)
        {
            int idExpirienceToModify = ExperienceRepository.Experiences.FindIndex(e => e.Id == idExperience);
            if(idExpirienceToModify != -1)
            {
                Experience newExpirience = new Experience()
                {
                    Id = idExperience,
                    Description = requestDto.Description,
                    Title = requestDto.Title,
                    ImagePath = requestDto.ImagePath,
                    Summary = ExperienceRepository.Experiences[idExpirienceToModify].Summary
                };
                ExperienceRepository.Experiences[idExpirienceToModify] = newExpirience;
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{idExperience}")]
        public IActionResult Delete([FromRoute]int idExperience) 
        {
            int idExpirienceToModify = ExperienceRepository.Experiences.FindIndex(e => e.Id == idExperience);
            if (idExpirienceToModify != -1)
            {
                Experience deletedExperience = new Experience()
                {
                    Id = idExperience,
                    Description = ExperienceRepository.Experiences[idExpirienceToModify].Description,
                    Title = ExperienceRepository.Experiences[idExpirienceToModify].Title,
                    ImagePath = ExperienceRepository.Experiences[idExpirienceToModify].ImagePath,
                    Summary = ExperienceRepository.Experiences[idExpirienceToModify].Summary,
                    State = "Deleted"
                };
                ExperienceRepository.Experiences[idExpirienceToModify] = deletedExperience;
                return NoContent();
            }
            return Ok();
        }


    }
}
