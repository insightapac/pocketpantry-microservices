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
        public int Qty { get; set; }
        public string Unit { get; set; }
        
        public Pantry Pantry { get; set; }
        public virtual ICollection<RecipeItem> RecipeItem { get; set; }        
        public ICollection<FoodItem> FoodItems { get; set; }
        
    }
}
