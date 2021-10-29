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
    public async Task<ActionResult<IEnumerable<Animal>>> Get(string animalName, string animalType)
    {
      var query = _db.Animals.AsQueryable();

      if (animalName != null)
      {
        query = query.Where(entry => entry.AnimalName == animalName);
      }

      if (animalType != null)
      {
        query = query.Where(entry => entry.AnimalType == animalType);
      }
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
  }
}