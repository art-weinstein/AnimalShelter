using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System;
using System.Linq;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get()
    {
      var query = _db.Animals.AsQueryable();

      // if (animalName != null)
      // {
      //   query = query.Where(entry => entry.AnimalName == animalName);
      // }

      // if (animalType != null)
      // {
      //   query = query.Where(entry => entry.AnimalType == animalType);
      // }
      return await query.ToListAsync();
    }

    [HttpGet("{id}")]

    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }
      return animal;
    }

    [HttpPut("{id}")]
    
    public async Task<ActionResult> Put(int id, Animal animal)
    {
      if(id != animal.AnimalId)
      {
        return BadRequest();
      }
      _db.Entry(animal).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
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

    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetAnimal), new{id = animal.AnimalId}, animal);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();
      return NoContent();
    }

    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }
  }
}
// finish controller