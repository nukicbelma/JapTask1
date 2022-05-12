using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RecipeDto
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
        public virtual ICollection<RecipeDetailDto> RecipeDetails { get; set; }

    }
}
