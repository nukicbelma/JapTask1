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
        public async Task<ActionResult<IEnumerable<RecipeDto>>> GetAll()
        {
            var query = _repo.Recipes.AsQueryable().ToList();
            var list = _mapper.Map<List<RecipeDto>>(query);
            return _mapper.Map<List<RecipeDto>>(list);
        }
        public  float totalRecipe(int recipeId)
        {
            var lista = _repo.RecipeDetails.Where(x => x.RecipeId == recipeId).ToList();
            float suma = 0;
            foreach (var item in lista)
            {
                suma += (float)item.Price;
            }
            return suma;
        }

        public async Task<IEnumerable<RecipeDto>> GetRecipesByCategory(int categoryId)
        {
            var listaRecepata = await _repo.Recipes.Include(x => x.Category).Where(u => u.CategoryId == categoryId).OrderBy(x=>x.TotalPrice).ToListAsync();
            return _mapper.Map<List<RecipeDto>>(listaRecepata);
        }
        public async Task<RecipeDto> GetRecipesById(int recipeId)
        {
            var recept = await _repo.Recipes.Include(x=>x.Category).Where(u => u.Id == recipeId).FirstOrDefaultAsync();
            recept.TotalPrice = (decimal)totalRecipe(recept.Id);

            return _mapper.Map<RecipeDto>(recept);
        }
        public async Task<ActionResult<Recipe>> AddRecipe(RecipeDto request)
        {
            var newRecipe = new Recipe
            {
                Name=request.Name, 
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
