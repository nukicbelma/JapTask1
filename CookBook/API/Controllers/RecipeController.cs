using API.DTOs;
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
    }
}
