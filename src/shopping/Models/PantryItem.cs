using System;
using System.Collections.Generic;

namespace Shopping.Models
{
    public partial class PantryItem
    {
        public PantryItem()
        {
            RecipeItem = new HashSet<RecipeItem>();
        }

        public int Id { get; set; }
        public int PantryId { get; set; }
        public int FoodItemId { get; set; }
        public string Qty { get; set; }
        public string Unit { get; set; }

        public FoodItem FoodItem { get; set; }
        public Pantry Pantry { get; set; }
        public ICollection<RecipeItem> RecipeItem { get; set; }
    }
}
