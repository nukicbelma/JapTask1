using API.Database;
using API.DTOs;
using API.Helpers;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
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
            var list = query.OrderBy(x => x.TotalPrice).ToList();
            return _mapper.Map<List<RecipeDto>>(list);
        }

        public async Task<IEnumerable<RecipeDto>> GetRecipesByCategory(int categoryId)
        {
            var listaRecepata = await _repo.Recipes.Include(x => x.Category).Where(u => u.CategoryId == categoryId).OrderBy(x=>x.TotalPrice).ToListAsync();
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
        public async Task<PagedList<RecipeDto>> GetRecipesPaging(int categoryId,PaginationParams p)
        {
            var query = _repo.Recipes.Include(x => x.Category).Where(u => u.CategoryId == categoryId).ProjectTo<RecipeDto>(_mapper.ConfigurationProvider)
                .AsQueryable().AsNoTracking();

            query = query.OrderBy(x => x.TotalPrice);
            return await PagedList<RecipeDto>.CreateAsync(query, p.PageNumber, p.PageSize);
        }
    }
}
