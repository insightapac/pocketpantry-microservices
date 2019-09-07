using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    [Table("MealPlan")]
    public class MealPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUri { get; set; }
        public string Filters { get; set; }
        public virtual MealCategory MealCategory { get; set; }
        public virtual ICollection<MealPlanRecipe> MealPlanRecipe { get; set; }
    }
}
