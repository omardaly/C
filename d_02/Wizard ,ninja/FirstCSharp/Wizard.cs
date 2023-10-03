public class Wizard : Human
{
  public Wizard(string name, int str, int intel, int dex, int hp=0): base (name,str,25,dex,50)
  {

  }
    public override int Attack(Human target)
    {
        int dmg = Strength * 3;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }
    public int Heal(Human target)
    {
        int heal = Strength * 3;
        target.Health -= heal;
        Console.WriteLine($"{Name} attacked {target.Name} for {heal} damage!");
        return target.Health;
    }
    }