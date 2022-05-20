using API.Database;
using API.DTOs;
using API.Extensions;
using API.Helpers;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly japtask1Context _context;

        public CategoriesController(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> Get()
        {
            return  await _categoryRepo.Get();
        }

        [HttpGet("getCategoryById/{id}")]
        public async Task<ActionResult<CategoryDto>> GetCategoryById(int id)
        {
            return await _categoryRepo.GetCategoryById(id);
        }

        [HttpGet("getCategoriesPaging")]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetCategoriesPaging([FromQuery] PaginationParams p)
        {
            var categories = await _categoryRepo.GetCategoriesPaging(p);
            Response.AddPaginationHeader(categories.CurrentPage, categories.PageSize, categories.TotalCount, categories.TotalPages);
            return Ok(categories);
        }
    }
}