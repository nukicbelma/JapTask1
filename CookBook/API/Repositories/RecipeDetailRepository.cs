using API.Database;
using API.DTOs;
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
        public List<RecipeDetailDto> GetAll()
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
            var newlistDto = new List<RecipeDetailDto>();
            foreach (var i in  ingredientListByRecipe)
            {
                var dto = new RecipeDetailDto
                {
                    RecipeId = i.RecipeId,
                    RecipteDetailId = i.RecipteDetailId,
                    Amount = i.Amount,
                    IngredientId = i.IngredientId,
                    UnitMeasure = i.UnitMeasure,
                    Price = i.Price,
                    Ingredient = i.Ingredient,
                    Recipe = i.Recipe
                };
                newlistDto.Add(dto);
            }
            return newlistDto;
        }

        public async Task<ActionResult<RecipeDetailDto>> AddIngredientToRecipe(int recipeId, RecipeDetailInsertDto request)
        {
            var find = _repo.Recipes.Find(recipeId);
            var novi = new RecipeDetail
            {
                Amount = request.Amount,
                IngredientId = request.IngredientId,
                RecipeId = recipeId,
                Recipe = find,
                UnitMeasure = request.UnitMeasure
            };
            _repo.RecipeDetails.Add(novi);
            await _repo.SaveChangesAsync();
            return _mapper.Map<RecipeDetailDto>(novi);
        }
    }
}
