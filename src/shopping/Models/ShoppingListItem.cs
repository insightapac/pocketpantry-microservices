using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Models
{
    [Table("ShoppingListItem")]
    public class ShoppingListItem
    {
        public int Id { get; set; }
       
        public virtual ShoppingList ShoppingList { get; set; }
        public int FoodItemID { get; set; }
        public FoodItem FoodItem { get; set; }
    }
}