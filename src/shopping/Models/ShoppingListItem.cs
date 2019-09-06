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
        public virtual ICollection<FoodItem> FoodItem { get; set; }
    }
}