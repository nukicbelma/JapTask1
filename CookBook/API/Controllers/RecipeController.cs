using API.Database;
using API.DTOs;
using API.Extensions;
using API.Helpers;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepository _repo;
        public RecipeController(IRecipeRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("getRecipesByCategory/{id}")]
        public async Task<IActionResult> GetRecipesByCategory(int id)
        {
            var recipes = await _repo.GetRecipesByCategory(id);
            return Ok(recipes);
        }

        [HttpGet("getRecipesById/{id}")]
        public async Task<IActionResult> GetRecipesById(int id)
        {
            var recipes = await _repo.GetRecipesById(id);
            return Ok(recipes);
        }

        [HttpGet]
        public List<RecipeDto> GetAll()
        {
            return _repo.GetAll();
        }

        [HttpPost("add")]
        public async Task<ActionResult<Recipe>> AddRecipe(RecipeDto request)
        {
            var recipe = await _repo.AddRecipe(request);
            return Ok(recipe);
        }

        [HttpGet("getRecipesPaging/{categoryId}")]
        public async Task<ActionResult<IEnumerable<RecipeDto>>> GetRecipesPaging(int categoryId,[FromQuery] PaginationParams p)
        {
            var categories = await _repo.GetRecipesPaging(categoryId,p);
            Response.AddPaginationHeader(categories.CurrentPage, categories.PageSize, categories.TotalCount, categories.TotalPages);
            return Ok(categories);

        }
    }
}
