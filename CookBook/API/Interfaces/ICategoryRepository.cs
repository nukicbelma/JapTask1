using API.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface ICategoryRepository
    {
        List<CategoryDto> Get();
        Task<ActionResult<CategoryDto>> GetCategoryById(int categoryId);
    }
}
