using System.Collections.Generic;

namespace API.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<RecipeDto> Recipes { get; set; }
    }
}
