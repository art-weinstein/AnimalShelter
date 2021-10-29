using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
            .HasData(
              new Animal { AnimalId = 1, AnimalName = "Robbie", AnimalType = "Dog",  AnimalAge = 7},
              new Animal { AnimalId = 2, AnimalName = "Debster", AnimalType = "Cat",  AnimalAge = 4},
              new Animal { AnimalId = 3, AnimalName = "Stibbons", AnimalType = "Cat",  AnimalAge = 2},
              new Animal { AnimalId = 4, AnimalName = "Doug", AnimalType = "Dog",  AnimalAge = 3},
              new Animal { AnimalId = 5, AnimalName = "Pumpkin", AnimalType = "Dog",  AnimalAge = 1}
            );
        }
    }
}