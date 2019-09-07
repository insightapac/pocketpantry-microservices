﻿using System;
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
        public int RecipeCategoryId { get; set; }
        public double CookingTime { get; set; }
        public string DifficultyLevel { get; set; }
        public double TotalCost { get; set; }
        public string RecipeDescription { get; set; }
        public string ImageUri { get; set; }

        public virtual RecipeCollections RecipeCategory { get; set; }
        public virtual ICollection<MealPlanRecipe> MealPlanRecipe { get; set; }
        
    }
}
