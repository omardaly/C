// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//! Array
int[] array1 = new int[10];
for (int i=0; i<9;i++)
{
    array1[i]=i;
}

string[] array2 ={"Tim","Martin","Nikki","Sara"};
Console.WriteLine(array2);
foreach(var name in array2)
{
    System.Console.WriteLine(name +"");
}


bool[] array3 = new bool[10];
for (int i = 0; i < 10; i++)

{
    array3[i] = i % 2 == 0; 
}
 Console.WriteLine("array3:");
        foreach (var value in array3)
        {
            Console.Write(value + " ");
        }



//! Lists
List<String> iceCream = new List<string>();
iceCream.Add("frez");
iceCream.Add("chokola");
iceCream.Add("fromboize");
iceCream.Add("jilate");
foreach(string a in iceCream)
System.Console.WriteLine(a);

System.Console.WriteLine(iceCream.Count());
System.Console.WriteLine(iceCream[2]);
iceCream.Remove("fromboize");

System.Console.WriteLine(iceCream.Count());


//!dictionary
Dictionary<string,string> dictionary = new Dictionary<string, string>();
dictionary.Add("array3","frez");
dictionary.Add("array2","chocola");
dictionary.Add("array1","fromboize");
 foreach(KeyValuePair<string,string> entry in dictionary)
System.Console.WriteLine(entry.Key+"-"+entry.Value);