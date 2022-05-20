using API.DTOs;
using API.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface ICategoryRepository
    {
        Task<ActionResult<IEnumerable<CategoryDto>>> Get();
        Task<ActionResult<CategoryDto>> GetCategoryById(int categoryId);
        Task<PagedList<CategoryDto>> GetCategoriesPaging(PaginationParams p);
    }
}
