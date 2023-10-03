public class Sniper : Soldier , IHaveWeapon
{
    public double Precision { get; set; }
    public double EagleEye {get; set;}
    public int MaxRange {get; set;}
    public string Weapon { get; set; }
    public bool IsFire { get; set; }
    public double NumberOfBullets { get; set; }

    // Constructors
    public Sniper(string name , int age, int maxRange): base(name,age)
    {
        Precision = 0.8;
        EagleEye = 0.75;
        MaxRange = maxRange;
        Weapon = "Sniper";
        IsFire = true;
        NumberOfBullets = 30;
    }
    //Methods
    //! override this method that belong to my parent(base) class=>Polymorphism
    public override void ShowInfo(){
        base.ShowInfo();
        System.Console.WriteLine($"Precision : {Precision}Pts\n EagleEye : {EagleEye}pts\n Max Range{MaxRange}M");
        
    }
    public void UseWeapon()
     {
        System.Console.WriteLine($"[SHOOT] {Name} used his {Weapon} .");
        NumberOfBullets -= 1;
    }
}