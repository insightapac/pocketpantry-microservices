using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    [Table("FoodItem")]
    public class FoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual RecipeItem RecipeItem { get; set; }
        public virtual ShoppingListItem ShoppingListItem { get; set; }
        public virtual PantryItem PantryItem { get; set; }
    }
}
