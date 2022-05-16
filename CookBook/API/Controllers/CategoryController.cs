using API.Database;
using API.DTOs;
using API.Extensions;
using API.Helpers;
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

        [HttpGet("getCategoriesPaging")]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetCategoriesPaging([FromQuery] PaginationParams p)
        {
            var categories = await _repo.GetCategoriesPaging(p);
            Response.AddPaginationHeader(categories.CurrentPage, categories.PageSize, categories.TotalCount, categories.TotalPages);
            return Ok(categories);

        }
    }
}