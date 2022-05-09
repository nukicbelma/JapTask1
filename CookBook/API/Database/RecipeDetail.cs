using System;
using System.Collections.Generic;

#nullable disable

namespace API.Database
{
    public partial class RecipeDetail
    {
        public int RecipteDetailId { get; set; }
        public int RecipeId { get; set; }
        public int Amount { get; set; }
        public int IngredientId { get; set; }
        public decimal Price { get; set; }
        public string UnitMeasure { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
