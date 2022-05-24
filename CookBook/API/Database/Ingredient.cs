using API.Helpers;
using System.Collections.Generic;

#nullable disable

namespace API.Database
{
    public partial class Ingredient :BaseEntity
    {
        public Ingredient()
        {
            RecipeIngredients = new HashSet<RecipeDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        public int PurchaseAmount { get; set; }
        public EnumUnits PurchaseMeasure { get; set; }

        public virtual ICollection<RecipeDetail> RecipeIngredients { get; set; }
    }
}
