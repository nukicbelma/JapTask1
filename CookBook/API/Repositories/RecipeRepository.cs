using API.Database;
using API.DTOs;
using API.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly japtask1Context _context;
        private readonly IMapper _mapper;

        public RecipeRepository(japtask1Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<RecipeDto> GetAll()
        {
            var query = _context.Recipes.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<RecipeDto>>(list);
        }

        public List<RecipeDto> GetRecipesByCategory(int id)
        {
            var query = _context.Recipes.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<RecipeDto>>(list);
        }
    }
}
