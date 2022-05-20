using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RecipeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
        public virtual ICollection<RecipeDetailDto> RecipeIngredients { get; set; }

    }
}
