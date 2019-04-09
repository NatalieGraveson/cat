using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace cats.Models
{
  public class Cat
  {
    [Required]
    [Range(1, 100000)]
    public int Id { get; set; }

    [Required]
    [MinLength(6)]
    public string Name { get; set; }



    public Cat(int id, string name)
    {
      Id = id;
      Name = name;
    }
  }
}