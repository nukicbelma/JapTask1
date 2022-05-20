using API.Database;
using API.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IRecipeDetailRepository
    {
        Task<IEnumerable<RecipeDetailDto>> GetIngredientsByRecipe(int recipeId);
        Task<IEnumerable<RecipeDetailDto>> GetRecipeDetailById(int categoryId);
        Task<ActionResult<IEnumerable<RecipeDetailDto>>> GetAll();
        Task<ActionResult<RecipeDetailDto>> AddIngredientToRecipe(int id,RecipeDetailInsertDto request);

    }
}
