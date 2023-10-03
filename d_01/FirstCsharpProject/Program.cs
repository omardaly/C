// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



// Data Types in C#
//Primitives

//type name = Value
//! Numbers
int age = 35 ;
float rate = 1.32f;//4 bytes
double grade = 3.25;//8 bytes
Console.WriteLine(age);
Console.WriteLine(rate);
Console.WriteLine(grade);
//! Char VS String
//char is primitive type (1 Character only single quote)
// string complex type , array of chars and double quote
 char tag = 'A';
 System.Console.WriteLine($"My Programming Level is {tag}");
 //!Boolean
 bool isValid = true;
 bool hasCovid = false;
 //!Bytes
 byte Cone =0;
 byte cTwo = 255;

 // Complex types
 //! String
 string FirstName = "Jhon";
Console.WriteLine($"My First Name is {FirstName} I am {age} years old.");
//! Arrays
/*
List with fixed type and Length
*/
int [] numbers = new int[5];
numbers[0]=1;
numbers[1]=2;
numbers[2]=3;
numbers[3]=4;
numbers[4]=5;
Console.WriteLine(numbers);
Console.WriteLine(numbers.Length);

//! Lists
List<int> gradeList = new List<int>();
gradeList.Add(22);
gradeList.Add(2);


List<string> NameList = new List<string>(){"James","Alice","Jhon","Sarah"};
System.Console.WriteLine(NameList.Count());
NameList .Add("Max");
System.Console.WriteLine(NameList.Count());
NameList.Remove("Jhon");
Console.WriteLine(  NameList.Count());
Console.WriteLine(NameList.IndexOf("Alice"));
NameList.Remove("Jhon");
Console.WriteLine("NameList.Count()");
NameList.Count();

//! Dictionary
Dictionary<int,string> MyDict = new Dictionary<int, string>(){
    {1,"John"},{2,"James"}
};
//! Enums
// public enum OrderStatus {
//     Pending = 1,
//     Canceled = 0,
//     Delivered=2
// };

//! condionals










//! Loops

// for (int i = 0; i< numbers.Length;i++)
// {
//     System.Console.WriteLine($"Number From For Loop:{numbers[i]}");
// }
//      foreach (var number in numbers)
//     {
//         System.Console.WriteLine($"Number From For Loop:{numbers[]}");
//     }


//!Casting
//Implicit Casting
int IntValue = 3;
double DoubleValue = IntValue;
byte ByteValue = 255;
int ByteToInt = ByteValue;
// Explicit casting
string StringValue = "300";
double doubleFromInt = (int)IntValue;
// byte byteFromInt =(int)StringValue;
// int StrToInt = (int)StringValue;
if (IntValue >255)
{
    byte byteFromInt = 255;
}
else
{
    byte byteFromInt = (byte)IntValue;
}
// 

//! Functions
static void SayHi()
{
    System.Console.WriteLine("Hi From Function!!!");
}
SayHi();


static int Add(int a, int b)
{
    return a+ b;
}
System.Console.WriteLine(Add(5,8));