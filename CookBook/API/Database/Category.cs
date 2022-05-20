using System.Collections.Generic;

#nullable disable

namespace API.Database
{
    public  class Category : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
