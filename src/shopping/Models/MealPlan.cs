using System;
using System.Collections.Generic;

namespace Shopping.Models
{
    public partial class MealPlan
    {
        public MealPlan()
        {
            MealPlanRecipe = new HashSet<MealPlanRecipe>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string ImageUri { get; set; }
        public string Filters { get; set; }


        public User User { get; set; }
        public ICollection<MealPlanRecipe> MealPlanRecipe { get; set; }
    }
}
