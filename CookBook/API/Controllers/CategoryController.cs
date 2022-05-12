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
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _repo;
        private readonly japtask1Context _context;

        public CategoryController(ICategoryRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public List<CategoryDto> Get()
        {
            return _repo.Get();
        }

        [HttpGet("getCategoryById/{id}")]
        public async Task<ActionResult<CategoryDto>> GetCategoryById(int id)
        {
            return await _repo.GetCategoryById(id);
        }
    }
}