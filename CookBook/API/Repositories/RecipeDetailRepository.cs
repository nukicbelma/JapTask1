using API.Database;
using API.DTOs;
using API.Interfaces;
using AutoMapper;
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
        //public async Task<RecipeDto> GetRecipesById(int recipeId)
        //{
        //    var listaRecepata = await _repo.Recipes.Include(x => x.Category).Where(u => u.RecipeId == recipeId).FirstOrDefaultAsync();
        //    return _mapper.Map<RecipeDto>(listaRecepata);
        //}
    }
}
