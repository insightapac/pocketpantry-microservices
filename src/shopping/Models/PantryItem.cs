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
        public virtual Pantry Pantry { get; set; }
        public virtual ICollection<FoodItem> FoodItem { get; set; }
    }
}
