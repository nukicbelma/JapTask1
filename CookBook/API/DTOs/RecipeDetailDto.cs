using API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RecipeDetailDto
    {
        public int Id { get; set; }

        public int Amount { get; set; }
        public decimal Price { get; set; }
        public string Measure { get; set; }
        public int IngredientId { get; set; }
        public virtual IngredientDto Ingredient { get; set; }
        public int RecipeId { get; set; }
        public virtual RecipeDto Recipe { get; set; }
    }
}
