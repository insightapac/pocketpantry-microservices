using Microsoft.EntityFrameworkCore;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Data
{
    public class ShoppingDataContext : DbContext
    {
        public ShoppingDataContext(DbContextOptions<ShoppingDataContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<ShoppingList> ShoppingList { get; set; }
        public DbSet<ShoppingListItem> ShoppingListItem { get; set; }
        public DbSet<FoodItem> FoodItem { get; set; }
        public DbSet<Pantry> Pantry { get; set; }
        public DbSet<PantryItem> PantryItem { get; set; }
        public DbSet<RecipeItem> RecipeItem { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<MealPlanRecipe> MealPlanRecipe { get; set; }
        public DbSet<MealPlan> MealPlan { get; set; }
        public DbSet<MealCategory> MealCategory { get; set; }
        public DbSet<RecipeCollections> RecipeCategory { get; set; }
    }
}
