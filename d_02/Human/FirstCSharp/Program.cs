// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Ninja ninja = new Ninja ("ninja");
System.Console.WriteLine(ninja.Name);

Human dojo= new Human ("dojo",10,5);
System.Console.WriteLine(dojo.Name);

ninja.Attack(dojo);
System.Console.WriteLine(dojo.Health);