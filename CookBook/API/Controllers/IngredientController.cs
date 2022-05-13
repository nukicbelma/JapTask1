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
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientRepository _repo;
        public IngredientController(IIngredientRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public List<IngredientDto> GetAll()
        {
            return _repo.GetAll();
        }
        [HttpGet("getUnits")]
        public List<string> GetUnits()
        {
            return _repo.GetUnits();
        }
        [HttpGet("getIngredientById/{id}")]
        public async Task<IActionResult> getIngredientById(int id)
        {
            var recipes = await _repo.getIngredientById(id);
            return Ok(recipes);
        }

        //[HttpGet("getRecipesById/{id}")]
        //public async Task<IActionResult> GetRecipesById(int id)
        //{
        //    var recipes = await _repo.GetRecipesById(id);
        //    return Ok(recipes);
        //}
    }
}
