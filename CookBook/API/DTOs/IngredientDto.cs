namespace API.DTOs
{
    public class IngredientDto  
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        public int PurchaseAmount { get; set; }
        public string PurchaseMeasure { get; set; }

        //public virtual ICollection<RecipeDetail> RecipeIngredients { get; set; }
    }
}
