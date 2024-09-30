using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Data.Entities;
using PortfolioAPI.Data.Repositories;
using PortfolioAPI.Models;

namespace PortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
        //1- Propiedad privada y de solo lectura del tipo de la clase que quiero inyectar;
        private readonly ExperienceRepository _experienceRepository;

        //2 - Asignarle en el constructor un parametro del tipo de la clase que quiero inyectar a la propiedad privada anterior
        public ExperienceController(ExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] bool includeDeleted = false)
        {
                return Ok(_experienceRepository.Get());

        }

        [HttpGet("{titleForSearch}")]
        public IActionResult Get(string titleForSearch)
        {
            return Ok(_experienceRepository.Get(titleForSearch));
        }

        [HttpPost]
        public IActionResult AddExperience([FromBody] ExperienceForCreationAndUpdateRequest requestdto)
        {
            Experience experience = new Experience()
            {
                Description = requestdto.Description,
                Title = requestdto.Title,
                ImgPath = requestdto.ImagePath,
                Summary = "En proceso"
            };

            return Ok(_experienceRepository.Add(experience));
        }


        //[HttpPut("{idExperience}")]
        //public IActionResult Update([FromRoute]int idExperience, [FromBody] ExperienceForCreationAndUpdateRequest requestDto)
        //{
        //    int idExpirienceToModify = _experienceRepository.Experiences.FindIndex(e => e.Id == idExperience);
        //    if(idExpirienceToModify != -1)
        //    {
        //        Experience newExpirience = new Experience()
        //        {
        //            Id = idExperience,
        //            Description = requestDto.Description,
        //            Title = requestDto.Title,
        //            ImagePath = requestDto.ImagePath,
        //            Summary = _experienceRepository.Experiences[idExpirienceToModify].Summary
        //        };
        //        _experienceRepository.Experiences[idExpirienceToModify] = newExpirience;
        //        return NoContent();
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}

        //[HttpDelete("{idExperience}")]
        //public IActionResult Delete([FromRoute]int idExperience) 
        //{
        //    int idExpirienceToModify = _experienceRepository.Experiences.FindIndex(e => e.Id == idExperience);
        //    if (idExpirienceToModify != -1)
        //    {
        //        Experience deletedExperience = new Experience()
        //        {
        //            Id = idExperience,
        //            Description = _experienceRepository.Experiences[idExpirienceToModify].Description,
        //            Title = _experienceRepository.Experiences[idExpirienceToModify].Title,
        //            ImagePath = _experienceRepository.Experiences[idExpirienceToModify].ImagePath,
        //            Summary = _experienceRepository.Experiences[idExpirienceToModify].Summary,
        //            State = "Deleted"
        //        };
        //        _experienceRepository.Experiences[idExpirienceToModify] = deletedExperience;
        //        return NoContent();
        //    }
        //    return Ok();
        //}


    }
}
