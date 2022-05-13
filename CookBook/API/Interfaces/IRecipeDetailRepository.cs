using API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IRecipeDetailRepository
    {
        Task<IEnumerable<RecipeDetailDto>> GetRecipeDetailById(int categoryId);
        List<RecipeDetailDto> GetAll();
    }
}
