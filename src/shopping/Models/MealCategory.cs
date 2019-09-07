using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    [Table("MealCategory")]
    public class MealCategory
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int MealPlanID { get; set; }
        public virtual MealPlan MealPlan { get; set; }
    }
}
