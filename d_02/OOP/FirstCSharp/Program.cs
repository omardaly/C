// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var john = new Soldier("John",35,0.5,1.0);
Soldier james = new Soldier("James",25);
System.Console.WriteLine(john.Name);
Sniper sam = new Sniper("sam",41,200);
// james.ShowInfo();
james.Attack(john,0.2);
// john.ShowInfo();
sam.ShowInfo();


List<Soldier> Army = new List<Soldier>(){
    john , james
};
foreach(Soldier soldier in Army)
{
    soldier.ShowInfo();
    System.Console.WriteLine("------------------------------------");
}

Mermaid alice = new Mermaid("Alice",0.65,true,"Magic Voice");
System.Console.WriteLine($"Alice Power Before: {alice.Power}");
var test = new Monster("Test",100,true,"Test");