using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    [Table("AllergieFoodItem")]
    public class AllergieFoodItem
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<FoodItem> FoodItems { get; set; }
    }
}
