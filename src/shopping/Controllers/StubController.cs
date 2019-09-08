using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping.Models;

namespace Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StubController : ControllerBase
    {
        // GET: api/GetFoodType
        [HttpGet("GetFoodType")]
        public IEnumerable<CulturalFoodType> GetFoodType()
        {
            List<CulturalFoodType> lstCulturalFoodType = new List<CulturalFoodType>();
            lstCulturalFoodType.Add(new CulturalFoodType(1, "Don't care (anything goes) (all)"));
            lstCulturalFoodType.Add(new CulturalFoodType(2, "Asian"));
            lstCulturalFoodType.Add(new CulturalFoodType(3, "Italian"));
            lstCulturalFoodType.Add(new CulturalFoodType(4, "Thai"));
            lstCulturalFoodType.Add(new CulturalFoodType(5, "Indian"));
            lstCulturalFoodType.Add(new CulturalFoodType(6, "Aussie BBQ"));
            lstCulturalFoodType.Add(new CulturalFoodType(7, "Greek"));

            return lstCulturalFoodType;
        }

        // GET: api/GetMealChoice
        [HttpGet("GetMealChoice")]
        public IEnumerable<MealChoice> GetMealChoice()
        {
            List<MealChoice> lstMealChoice = new List<MealChoice>();
            lstMealChoice.Add(new MealChoice(1, "Don't care (anything goes) (all)"));
            lstMealChoice.Add(new MealChoice(2, "High Fibre"));
            lstMealChoice.Add(new MealChoice(3, "Low Carb"));
            lstMealChoice.Add(new MealChoice(4, "Vegan"));
            lstMealChoice.Add(new MealChoice(5, "Vegetarian"));
            lstMealChoice.Add(new MealChoice(6, "Paleo"));
            lstMealChoice.Add(new MealChoice(7, "Fish"));
            lstMealChoice.Add(new MealChoice(8, "Red meat"));
            lstMealChoice.Add(new MealChoice(9, "White meat"));
            lstMealChoice.Add(new MealChoice(10, "Healthy "));

            return lstMealChoice;
        }
    }
}
