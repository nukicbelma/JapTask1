using API.Database;
using API.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IRecipeRepository
    {
        Task<IEnumerable<RecipeDto>> GetRecipesByCategory(int categoryId);
        List<RecipeDto> GetAll();
        Task<RecipeDto> GetRecipesById(int recipeId);

        Task<ActionResult<Recipe>> AddRecipe(RecipeDto request);
    }
}
