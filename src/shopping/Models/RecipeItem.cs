using System;
using System.Collections.Generic;

namespace Shopping.Models
{
    public partial class RecipeItem
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int FoodItemId { get; set; }
        public int PantryItemId { get; set; }
        public int Qty { get; set; }
        public string Unit { get; set; }
        public string Note { get; set; }

        public FoodItem FoodItem { get; set; }
        public PantryItem PantryItem { get; set; }
        public Recipe Recipe { get; set; }
    }
}
