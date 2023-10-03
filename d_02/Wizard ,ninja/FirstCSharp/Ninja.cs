public class Ninja: Human
{
    public Ninja(string name, int str, int intel, int dex, int hp): base (name,str,intel,75,hp)
  {

  }
  public override int Attack(Human target)
  
    {
        int dmg = Dexterity;
        Random rand = new Random();
        if (rand.Next(1,5)==2)
        {
            dmg+=10;
        }
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }
     public virtual int Steal(Human target)
    {
        
        
        target.Health -= 5;
        this.Health += 5;
        Console.WriteLine($"{Name} steal 5HP form {target.Name} !");
        return target.Health;
    }
}


 