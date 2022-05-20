using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RecipeDetailInsertDto
    {
      
        public int Amount { get; set; }
        public int IngredientId { get; set; }
        public string Measure { get; set; }
        public int RecipeId { get; set;   }
    }
}
