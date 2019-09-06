using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    [Table("Recipe")]
    public class Recipe
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }

        public virtual ICollection<RecipeSteps> Steps { get; set; }
        public virtual ICollection<RecipeItem> Ingredients { get; set; }
        public virtual RecipeCategory RecipeCategory { get; set; }
        public virtual ICollection<MealPlanRecipe> MealPlanRecipe { get; set; }
    }
}
