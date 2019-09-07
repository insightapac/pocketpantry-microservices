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
        public int PreperationTime { get; set; }
        public int CookTime { get; set; }
        public int Servings { get; set; }
        public byte[] Difficulty { get; set; }
        public int Energy { get; set; }
        public double FatTotal { get; set; }
        public double SaturatedFat { get; set; }
        public double Fibre { get; set; }
        public double Protein { get; set; }
        public double Sodium { get; set; }
        public double CarbsSugar { get; set; }
        public double CarbsTotal { get; set; }
        public int NumIngredients { get; set; }
        public int RecipeCategoryId { get; set; }

        public Category RecipeCategory { get; set; }
        public ICollection<MealPlanRecipe> MealPlanRecipe { get; set; }
        public ICollection<RecipeItem> RecipeItem { get; set; }
        public ICollection<RecipeSteps> RecipeSteps { get; set; }
    }
}
