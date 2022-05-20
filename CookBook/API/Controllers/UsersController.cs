using API.DTOs;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repo;

        public UserController(IUserRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("api/users")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            return await _repo.GetUsers();
        }
        [HttpPost("Login/")]
        public Task<UserDto> Login([FromQuery] LoginDto model)
        {
            return _repo.Login(model);
        }
    }
}
