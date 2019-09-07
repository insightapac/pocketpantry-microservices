using System;
using System.Collections.Generic;

namespace Shopping.Models
{
    public partial class Recipe
    {
        public Recipe()
        {
            MealPlanRecipe = new HashSet<MealPlanRecipe>();
            RecipeItem = new HashSet<RecipeItem>();
            RecipeSteps = new HashSet<RecipeSteps>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PreperationTime { get; set; }
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
        public int RecipeCategoryId { get; set; }

        public Category RecipeCategory { get; set; }
        public ICollection<MealPlanRecipe> MealPlanRecipe { get; set; }
        public ICollection<RecipeItem> RecipeItem { get; set; }
        public ICollection<RecipeSteps> RecipeSteps { get; set; }
    }
}
