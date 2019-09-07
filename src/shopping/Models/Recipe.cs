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
        public string ImageURL { get; set; }
        public string ShortDescription { get; set; }
        public string PreparationTime { get; set; }
        public string CookTime { get; set; }
        public string Servings { get; set; }
        public string Difficulty { get; set; }
        public string Energy { get; set; }
        public string FatTotal { get; set; }
        public string SaturatedFat { get; set; }
        public string Fibre { get; set; }
        public string Protein { get; set; }
        public string Sodium { get; set; }
        public string CarbsSugar { get; set; }
        public string CarbsTotal { get; set; }
        public int NumIngredients { get; set; }       
        public double CookingTime { get; set; }
        public string DifficultyLevel { get; set; }
        public double TotalCost { get; set; }
        public string RecipeDescription { get; set; }
        public string ImageUri { get; set; }
        public int RecipeCollectionID { get; set; }
        public RecipeCollection RecipeCollection { get; set; }
        public virtual ICollection<RecipeSteps> Steps { get; set; }
        public virtual ICollection<RecipeItem> Ingredients { get; set; }
        public virtual ICollection<MealPlanRecipe> MealPlanRecipe { get; set; }
        
    }
}
