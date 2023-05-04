using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class TamagotchiPet
  {
    public string Name { get; set; }
    public int Food { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }
    private static List<TamagotchiPet>_instances = new List<TamagotchiPet> { };
    public TamagotchiPet (string name, int food, int attention, int rest)
  {
    Name = name;
    Food = 100;
    Attention = 100;
    Rest = 100;
    _instances.Add(this);
    
  }
  public static List<TamagotchiPet>GetAll()
  {
    return _instances;
  }

    public void Feed()
    {
      Food += 10;
      Attention -= 5;
      Rest -= 5;
    }
    public void GiveAttention()
    {
      Food -= 10;
      Attention += 10;
      Rest -= 5;
    }
    public void LetRest()
    {
      Food -= 20;
      Attention -= 10;
      Rest += 20;
    }

  }

}