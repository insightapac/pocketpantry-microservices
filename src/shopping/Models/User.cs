using System;
using System.Collections.Generic;

namespace Shopping.Models
{
    public partial class User
    {
        public User()
        {
            AllergieFoodItem = new HashSet<AllergieFoodItem>();
            MealPlan = new HashSet<MealPlan>();
            Pantry = new HashSet<Pantry>();
            ShoppingList = new HashSet<ShoppingList>();
        }

        public int Id { get; set; }
        public Guid ObjectId { get; set; }

        public ICollection<AllergieFoodItem> AllergieFoodItem { get; set; }
        public ICollection<MealPlan> MealPlan { get; set; }
        public ICollection<Pantry> Pantry { get; set; }
        public ICollection<ShoppingList> ShoppingList { get; set; }
    }
}
