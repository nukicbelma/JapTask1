using API.Database;
using API.DTOs;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    //[Route("[api/controller]")]
    //[Authorize]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserRepository _repo;

        public AppUserController(IAppUserRepository repo)
        {
            _repo = repo;
        }

        //[HttpGet]
        //[AllowAnonymous]
        //[Route("Authenticiraj/{username},{password}")]
        //public AppUserDto Authenticiraj(string username, string password)
        //{
        //    return _repo.Authenticiraj(username, password);
        //}

        [HttpGet]
        [Route("api/users")]
        public List<AppUserDto>GetUsers()
        {
            return _repo.GetUsers();
        }

        //public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        //{
        //    return await _context.AppUsers.ToListAsync();
        //}

    }
}
