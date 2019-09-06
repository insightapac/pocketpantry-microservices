using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    [Table("MealPlanRecipe")]
    public class MealPlanRecipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Recipe Recipe { get; set; }
        public virtual MealPlan MealPlan { get; set; }

    }
}
