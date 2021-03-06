using API.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IIngredientRepository
    {
        Task<ActionResult<IEnumerable<IngredientDto>>> GetAll();
        Task<IngredientDto> getIngredientById(int ingredientId);
        List<string> GetUnits();
    }
}
