using System;
using System.Collections.Generic;

namespace Shopping.Models
{
    public partial class ShoppingListItem
    {
        public int Id { get; set; }
        public int ShoppingListId { get; set; }
        public double Qty { get; set; }
        public string Unit { get; set; }
        public int FoodItemId { get; set; }

        public FoodItem FoodItem { get; set; }
        public ShoppingList ShoppingList { get; set; }
    }
}
