using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Models
{
    [Table("ShoppingListItem")]
    public class ShoppingListItem
    {
        public int Id { get; set; }        
        public int Qty { get; set; }
        public string Unit { get; set; }
        public virtual ShoppingList ShoppingList { get; set; }      
        public ICollection<FoodItem> FoodItems { get; set; }
    }
}