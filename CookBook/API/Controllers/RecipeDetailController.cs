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
    public class RecipeDetailController : ControllerBase
    {
        private readonly IRecipeDetailRepository _repo;
        public RecipeDetailController(IRecipeDetailRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("getRecipeDetailById/{id}")]
        public async Task<IActionResult> GetRecipeDetailById(int id)
        {
            var recipes = await _repo.GetRecipeDetailById(id);
            return Ok(recipes);
        }

        [HttpGet]
        public List<RecipeDetailDto> GetAll()
        {
            return _repo.GetAll();
        }

        [HttpGet]
        [Route("getIngredientsByRecipe/{id}")]
        public async Task<IActionResult> GetIngredientsByRecipe(int id)
        {
            var ingredients = await _repo.GetIngredientsByRecipe(id);
            return Ok(ingredients);
        }

        [HttpPost("add/{id}")]
        public async Task<ActionResult<RecipeDetail>> AddRecipe(int id,RecipeDetailInsertDto request)
        {
            var recipe = await _repo.AddIngredientToRecipe(id,request);
            return Ok(recipe);
        }
    }
}
