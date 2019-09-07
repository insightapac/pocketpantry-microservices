using System;
using System.Collections.Generic;

namespace Shopping.Models
{
    public partial class FoodItem
    {
        public FoodItem()
        {
            AllergieFoodItem = new HashSet<AllergieFoodItem>();
            PantryItem = new HashSet<PantryItem>();
            RecipeItem = new HashSet<RecipeItem>();
            ShoppingListItem = new HashSet<ShoppingListItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<AllergieFoodItem> AllergieFoodItem { get; set; }
        public ICollection<PantryItem> PantryItem { get; set; }
        public ICollection<RecipeItem> RecipeItem { get; set; }
        public ICollection<ShoppingListItem> ShoppingListItem { get; set; }
    }
}
