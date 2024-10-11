using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Data.Entities;
using PortfolioAPI.Data.Repositories;
using PortfolioAPI.Models;

namespace PortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        public AuthenticateController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost]
        public IActionResult Authenticate([FromBody] CredentialsForAutheticateDTO credentials)
        {
            User? userAuthenticated = _userRepository.Authenticate(credentials.Username, credentials.Password);
            if (userAuthenticated is not null)
            {
                return Ok("llavetoken");
            }
            return Unauthorized();
        }
    }
}
