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
    [ApiController]
    [Route("[controller]")]
    //[Authorize]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepository _service;
        public RecipeController(IRecipeRepository service)
        {
            _service = service;
        }

        [HttpGet]
        public List<RecipeDto> GetAll()
        {
            return _service.GetAll();
        }
    }
}
