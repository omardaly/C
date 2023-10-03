// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Ninja james = new Ninja ("James",20,10,75,10);
Wizard hazem = new Wizard("hazem",20,10,30,50);
Wizard wajdi = new Wizard("wajdi",20,10,30);
Samurai jadi = new Samurai("jadi",20,10,30,30);

james.Attack(hazem);
System.Console.WriteLine(hazem.Health);

jadi.Attack(wajdi);
System.Console.WriteLine(wajdi.Health);

