using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shopping.Data;
using Shopping.Models;
using Shopping.Models.Dtos;

namespace Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealPlanController : ControllerBase
    {

        private readonly ShoppingDataContext _context;

        public MealPlanController(ShoppingDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IList<MealPlanDto> GetMealPlans()
        {
            return GetMealPlansDto(); 
        }

        private IList<MealPlanDto> GetMealPlansDto()
        {
            IList<MealPlanDto> list = new List<MealPlanDto>();
            _context.MealPlan.ToList().ForEach(x => {
                list.Add(new MealPlanDto
                {
                    Filters = JsonConvert.DeserializeObject<string[]>(x.Filters),
                    Img = x.ImageUri,
                    Name = x.Name
                });
           });
            throw new Exception("No meal plans!");
        }
    }
}