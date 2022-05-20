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
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeRepository _recipeRepository;
        public RecipesController(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        [HttpGet("getRecipesByCategory/{id}")]
        public async Task<IActionResult> GetRecipesByCategory(int id)
        {
            var recipes = await _recipeRepository.GetRecipesByCategory(id);
            return Ok(recipes);
        }

        [HttpGet("getRecipesById/{id}")]
        public async Task<IActionResult> GetRecipesById(int id)
        {
            var recipes = await _recipeRepository.GetRecipesById(id);
            return Ok(recipes);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecipeDto>>> GetAll()
        {
            return await _recipeRepository.GetAll();
        }

        [HttpPost("add")]
        public async Task<ActionResult<Recipe>> AddRecipe(RecipeDto request)
        {
            var recipe = await _recipeRepository.AddRecipe(request);
            return Ok(recipe);
        }

        [HttpGet("getRecipesPaging/{categoryId}")]
        public async Task<ActionResult<IEnumerable<RecipeDto>>> GetRecipesPaging(int categoryId,[FromQuery] PaginationParams p)
        {
            var categories = await _recipeRepository.GetRecipesPaging(categoryId,p);
            Response.AddPaginationHeader(categories.CurrentPage, categories.PageSize, categories.TotalCount, categories.TotalPages);
            return Ok(categories);
        }
    }
}
