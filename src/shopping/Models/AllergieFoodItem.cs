using System;
using System.Collections.Generic;

namespace Shopping.Models
{
    public partial class AllergieFoodItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FoodItemId { get; set; }

        public FoodItem FoodItem { get; set; }
        public User User { get; set; }
    }
}
