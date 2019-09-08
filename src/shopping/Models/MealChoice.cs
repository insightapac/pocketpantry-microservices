using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class MealChoice
    {
        public int Id { get; set; }
        public string MealChoiceType { get; set; }

        public MealChoice(int id, string mealChoiceType ) {
            this.Id = id;
            this.MealChoiceType = mealChoiceType;
        }
    }
}
