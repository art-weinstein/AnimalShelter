using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string AnimalName { get; set; }
    public string AnimalType { get; set; }
    public int AnimalAge { get; set; }
    public string AnimalBreed { get; set; }
  }
}