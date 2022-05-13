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
    public class IngredientRepository : IIngredientRepository
    {
        private readonly japtask1Context _repo;
        private readonly IMapper _mapper;

        public IngredientRepository(japtask1Context repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public List<IngredientDto> GetAll()
        {
            var query = _repo.Ingredients.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<IngredientDto>>(list);
        }
        public async Task<IngredientDto> getIngredientById(int id)
        {
            var listaRecepata = await _repo.Ingredients.Where(u => u.IngredientId == id).FirstOrDefaultAsync();
            return _mapper.Map<IngredientDto>(listaRecepata);
        }
        public List<string> GetUnits()
        {
            var list = new List<string> { "kg", "g", "l", "kom", "ml" };
            return list;
        }

    }
}
