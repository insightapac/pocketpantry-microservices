using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    [Table("RecipeItem")]
    public class RecipeItem
    {
        public int Id { get; set; }
        public int ItemID { get; set; }       
        
        public int FoodItemID { get; set; }
        public virtual Recipe Recipe { get; set; }
        public FoodItem FoodItem { get; set; }
        public PantryItem PantryItem { get; set; }
    }
}
