using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class CulturalFoodType
    {
        public int Id { get; set; }
        public string FoodType { get; set; }

        public CulturalFoodType(int id, string foodType)
        {
            this.Id = id;
            this.FoodType = foodType;
        }

    }
}
