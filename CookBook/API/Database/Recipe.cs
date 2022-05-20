using System;
using System.Collections.Generic;

#nullable disable

namespace API.Database
{
    public partial class Recipe : BaseEntity
    {
        public Recipe()
        {
            RecipeIngredients = new HashSet<RecipeDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<RecipeDetail> RecipeIngredients { get; set; }
    }
}
