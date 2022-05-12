using API.Database;
using API.DTOs;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    //[Route("[api/controller]")]
    //[Authorize]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _repo;
        private readonly japtask1Context _context;

        public CategoryController(ICategoryRepository repo)
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
        [Route("api/category")]
        public List<CategoryDto> Get()
        {
            return _repo.Get();
        }
    }
}