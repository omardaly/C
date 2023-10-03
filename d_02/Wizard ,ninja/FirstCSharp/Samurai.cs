public class Samurai: Human
{
      public Samurai(string name, int str, int intel, int dex, int hp=0): base (name,str,intel,dex,200)
      {

      }
      public override int Attack(Human target)
    {
        base.Attack(target);
        // int dmg = Strength * 3;
        if (target.Health<50)
        {
            target.Health=0;
        }
        // target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name}  damage!");
        return target.Health;
    }
     public  int Meditate(Human health)
    {
        if (Health<50)
        {
            Health=50;
        }
        // target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {Name}  damage!");
        return Health;
    }

}