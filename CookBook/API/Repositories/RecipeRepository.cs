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
    public class RecipeRepository : IRecipeRepository
    {
        private readonly japtask1Context _repo;
        private readonly IMapper _mapper;

        public RecipeRepository(japtask1Context repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public List<RecipeDto> GetAll()
        {
            var query = _repo.Recipes.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<RecipeDto>>(list);
        }

        public async Task<IEnumerable<RecipeDto>> GetRecipesByCategory(int categoryId)
        {
            var listaRecepata = await _repo.Recipes.Include(x => x.Category).Where(u => u.CategoryId == categoryId).ToListAsync();
            return _mapper.Map<List<RecipeDto>>(listaRecepata);
        }
        public async Task<RecipeDto> GetRecipesById(int recipeId)
        {
            var listaRecepata = await _repo.Recipes.Include(x=>x.Category).Where(u => u.RecipeId == recipeId).FirstOrDefaultAsync();
            return _mapper.Map<RecipeDto>(listaRecepata);
        }
        public async Task<ActionResult<Recipe>> AddRecipe(RecipeDto request)
        {
            var newRecipe = new Recipe
            {
                RecipeName=request.RecipeName, 
                CategoryId=request.CategoryId,
                Description=request.Description,
            };

            _repo.Recipes.Add(newRecipe);
            await _repo.SaveChangesAsync();
            return _mapper.Map<Recipe>(newRecipe);
        }
    }
}
