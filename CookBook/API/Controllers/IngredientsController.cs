using API.DTOs;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientRepository _ingredientsRepo;
        public IngredientsController(IIngredientRepository ingredientsRepo)
        {
            _ingredientsRepo = ingredientsRepo;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IngredientDto>>> GetAll()
        {
            return  await _ingredientsRepo.GetAll();
        }
        [HttpGet("getUnits")]
        public async Task<ActionResult<IEnumerable<string>>> GetUnits()
        {
            return _ingredientsRepo.GetUnits();
        }
        [HttpGet("getIngredientById/{id}")]
        public async Task<IActionResult> getIngredientById(int id)
        {
            var recipes = await _ingredientsRepo.getIngredientById(id);
            return Ok(recipes);
        }
    }
}
