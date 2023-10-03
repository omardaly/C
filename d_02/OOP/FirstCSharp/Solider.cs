/* 
class ? blueprint or template to create objects
 class : 
        Attributes/Fields : what the class can have Data
        Methods : what the class can doo or behave
 Objects : Instance of the class.

 In Python :
        Class Solider :
        def__init_(self,name):
        self.name

In JavaScript :
        class Solider {
            constructor(name){
                this.name = name
            }

        }
*/

public class Soldier 
{
    // Attributes /Properties
    //! type --Attribute name + get set -->Proprety
     public string Name{get;set;}
     public int Age{get;set;}
     public double Power {get;set;}
     public double Health{get;set;}
    // Constructor
   public Soldier(string name, int age)
    {
        Name = name;
        Age = age;
        Power = 2;
        Health = 1;

    }
    public Soldier(string name, int age,double power, double health)
    {
        Name = name;
        Age = age;
        Power = power;
        Health = health;

    }
    //Methods
    //! Virtual : can be changed by child classes
    public virtual void ShowInfo()
    {
        System.Console.WriteLine($"Name :{Name}\nAge:{Age}\n power:{Power}\n health: {Health}");
        System.Console.WriteLine("----------------------\n");
    }
    public int IncreasAge()
    {
        Age+=1;
        return Age;
    }
    public double Train(double amount)
    {
        Power+= amount;
        return Power;
    }
    public void Attack(Soldier target , double damageRate)
    {
        target.Health -= Power*damageRate;
        System.Console.WriteLine($"[ATTack] Solider {Name}\n attacked Solider {target.Name}\nby Damage Rate equals to {damageRate}");
    }

}