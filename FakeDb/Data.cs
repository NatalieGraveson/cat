using System.Collections.Generic;
using cats.Models;



namespace cats.DataBase
{


  public static class Data
  {

    public static List<Cat> Inventory = new List<Cat>()
    {
      new Cat(22222, "kitty Kat"),
      new Cat(33333, "Silly Willy"),
      new Cat(44444, "Wacky Willy")
    };

  }
}