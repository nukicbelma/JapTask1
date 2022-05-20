using API.Database;
using API.DTOs;
using API.Helpers;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class RecipeDetailRepository : IRecipeDetailRepository
    {
        private readonly japtask1Context _repo;
        private readonly IMapper _mapper;

        public RecipeDetailRepository(japtask1Context repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<ActionResult<IEnumerable<RecipeDetailDto>>> GetAll()
        {
            var query = _repo.RecipeDetails.Include(x=>x.Ingredient).Include(x=>x.Recipe).AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<RecipeDetailDto>>(list);
        }

        public async Task<IEnumerable<RecipeDetailDto>> GetRecipeDetailById(int rpId)
        {
            var details = await _repo.RecipeDetails.Include(x => x.Recipe).Where(u => u.RecipeId == rpId).ToListAsync();
            return _mapper.Map<List<RecipeDetailDto>>(details);
        }
        public async Task<IEnumerable<RecipeDetailDto>> GetIngredientsByRecipe(int recipeId)
        {
            var ingredientListByRecipe =await _repo.RecipeDetails.Include(x => x.Ingredient).Where(x => x.RecipeId == recipeId).ToListAsync();
            return _mapper.Map<List<RecipeDetailDto>>(ingredientListByRecipe);
        }
        public float totalRecipe(int recipeId)
        {
            var lista = _repo.RecipeDetails.Where(x => x.RecipeId == recipeId).ToList();
            float suma = 0;
            foreach (var item in lista)
            {
                suma += (float)item.Price;
            }
            return suma;
        }

        public async Task<ActionResult<RecipeDetailDto>> AddIngredientToRecipe(int recipeId, RecipeDetailInsertDto request)
        {
            var find = _repo.Recipes.Find(recipeId);
            var ingredient = _repo.Ingredients.Find(request.IngredientId);
            var novi = new RecipeDetail
            {
                Amount = request.Amount,
                IngredientId = request.IngredientId,
                RecipeId = recipeId,
                Recipe = find,
                Measure = request.Measure,
                Price = (decimal)GetTotalPrice.getTotal(request.Amount, request.Measure, ingredient.PurchaseAmount, (int)ingredient.PurchasePrice, ingredient.PurchaseMeasure),
            };

            _repo.RecipeDetails.Add(novi);
            var update = _repo.Recipes.Find(recipeId);
           

            await _repo.SaveChangesAsync();
            update.TotalPrice = (decimal)totalRecipe(recipeId);
            await _repo.SaveChangesAsync();
            return _mapper.Map<RecipeDetailDto>(novi);
        }
    }
}
