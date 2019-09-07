using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping.Data;
using Shopping.Models;

namespace Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemsController : ControllerBase
    {
        private readonly ShoppingDataContext _context;

        public FoodItemsController(ShoppingDataContext context)
        {
            _context = context;
        }

        // GET: api/FoodItems
        [HttpGet]
        public IEnumerable<FoodItem> GetFoodItem()
        {
            return _context.FoodItem;
        }

        // GET: api/FoodItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFoodItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var foodItem = await _context.FoodItem.FindAsync(id);

            if (foodItem == null)
            {
                return NotFound();
            }

            return Ok(foodItem);
        }

        // GET: api/FoodItems/Search
        [HttpGet("Search/{searchText}")]
        public async Task<IActionResult> Search([FromRoute] string searchText)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var foodItem =  (List<FoodItem>)_context.FoodItem.Where(f=> f.Name.StartsWith(searchText)).ToList();

            if (foodItem == null)
            {
                return NotFound();
            }

            return Ok(foodItem);
        }

        // PUT: api/FoodItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoodItem([FromRoute] int id, [FromBody] FoodItem foodItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != foodItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(foodItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FoodItems
        [HttpPost]
        public async Task<IActionResult> PostFoodItem([FromBody] FoodItem foodItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.FoodItem.Add(foodItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFoodItem", new { id = foodItem.Id }, foodItem);
        }

        // DELETE: api/FoodItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoodItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var foodItem = await _context.FoodItem.FindAsync(id);
            if (foodItem == null)
            {
                return NotFound();
            }

            _context.FoodItem.Remove(foodItem);
            await _context.SaveChangesAsync();

            return Ok(foodItem);
        }

        private bool FoodItemExists(int id)
        {
            return _context.FoodItem.Any(e => e.Id == id);
        }
    }
}