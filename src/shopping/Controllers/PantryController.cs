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
    public class PantryController : ControllerBase
    {
        private readonly ShoppingDataContext _context;

        public PantryController(ShoppingDataContext context)
        {
            _context = context;
        }

        // GET: api/Pantry
        [HttpGet]
        public IEnumerable<Pantry> GetPantry()
        {
            return _context.Pantry;
        }

        // GET: api/Pantry/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPantry([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pantry = await _context.Pantry.FindAsync(id);

            if (pantry == null)
            {
                return NotFound();
            }

            return Ok(pantry);
        }

        // PUT: api/Pantry/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPantry([FromRoute] int id, [FromBody] Pantry pantry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pantry.Id)
            {
                return BadRequest();
            }

            _context.Entry(pantry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PantryExists(id))
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

        // POST: api/Pantry
        [HttpPost]
        public async Task<IActionResult> PostPantry([FromBody] Pantry pantry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Pantry.Add(pantry);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPantry", new { id = pantry.Id }, pantry);
        }

        // DELETE: api/Pantry/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePantry([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pantry = await _context.Pantry.FindAsync(id);
            if (pantry == null)
            {
                return NotFound();
            }

            _context.Pantry.Remove(pantry);
            await _context.SaveChangesAsync();

            return Ok(pantry);
        }

        private bool PantryExists(int id)
        {
            return _context.Pantry.Any(e => e.Id == id);
        }
    }
}