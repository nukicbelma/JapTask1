using System;
using System.Collections.Generic;

#nullable disable

namespace API.Database
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            RecipeDetails = new HashSet<RecipeDetail>();
        }

        public int IngredientId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string UnitMeasure { get; set; }

        public virtual ICollection<RecipeDetail> RecipeDetails { get; set; }
    }
}
