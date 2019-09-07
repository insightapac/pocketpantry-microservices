using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    [Table("PantryItem")]
    public class PantryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FoodItemID { get; set; }
        public FoodItem FoodItem { get; set; }
        public virtual ICollection<RecipeItem> RecipeItem { get; set; }
    }
}
