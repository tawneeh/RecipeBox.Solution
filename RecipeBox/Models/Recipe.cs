  
using System.Collections.Generic;

namespace RecipeBox.Models
{
    public class Recipe
    {
        public Recipe()
        {
            this.Categories = new HashSet<CategoryRecipe>();
        }

        public int RecipeId { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; } // 1 - 10
        public virtual ApplicationUser User { get; set; }

        public ICollection<CategoryRecipe> Categories { get;}
    }
}