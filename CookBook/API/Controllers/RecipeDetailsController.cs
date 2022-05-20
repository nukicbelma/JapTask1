using API.Database;
using API.DTOs;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeDetailsController : ControllerBase
    {
        private readonly IRecipeDetailRepository _recipeDetailRepo;
        public RecipeDetailsController(IRecipeDetailRepository recipeDetail)
        {
            _recipeDetailRepo = recipeDetail;
        }

        [HttpGet("getRecipeDetailById/{id}")]
        public async Task<IActionResult> GetRecipeDetailById(int id)
        {
            var recipes = await _recipeDetailRepo.GetRecipeDetailById(id);
            return Ok(recipes);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecipeDetailDto>>> GetAll()
        {
            return  await _recipeDetailRepo.GetAll();
        }

        [HttpGet]
        [Route("getIngredientsByRecipe/{id}")]
        public async Task<IActionResult> GetIngredientsByRecipe(int id)
        {
            var ingredients = await _recipeDetailRepo.GetIngredientsByRecipe(id);
            return Ok(ingredients);
        }

        [HttpPost("add/{id}")]
        public async Task<ActionResult<RecipeDetail>> AddRecipe(int id,RecipeDetailInsertDto request)
        {
            var recipe = await _recipeDetailRepo.AddIngredientToRecipe(id,request);
            return Ok(recipe);
        }
    }
}
