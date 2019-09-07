using System;
using System.Collections.Generic;

namespace Shopping.Models
{
    public partial class MealPlanRecipe
    {
        public int Id { get; set; }
        public int MealPlanId { get; set; }
        public int RecipeId { get; set; }

        public MealPlan MealPlan { get; set; }
        public Recipe Recipe { get; set; }
    }
}
