public class Ninja
{
    // Properties for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;

    public Ninja(string name)
    {
        Name = name;
       Strength = 50;
       Intelligence = 20;
       Dexterity = 3;
       Health = 100;


    }
    public int Attack(Human target)
    {
       int dmg = Strength*3;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }
}