using API.Database;
using API.DTOs;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IMapper _mapper;
        private readonly japtask1Context _context;

        public CategoryRepository(japtask1Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<CategoryDto> Get()
        {
            var query = _context.Categories.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<CategoryDto>>(list);
        }
        public async Task<ActionResult<CategoryDto>> GetCategoryById(int categoryId)
        {
            var category= await _context.Categories.FindAsync(categoryId);
            return _mapper.Map<CategoryDto>(category);
        }

    }
}
