using System;
namespace ReadAndWrite;
class Program
{
    public static void Main(string[] args)
    {
        //Get input
        Console.Write("Enter your Name:");
        string name = Console.ReadLine();
        Console.Write("Enter your Father Name:");
        string fatherName = Console.ReadLine();
        //print res
        //concat
        Console.WriteLine(name + " " + fatherName);
        //Placeholder
        Console.WriteLine("{0} {1}",name,fatherName);
        //Interpolation
        Console.WriteLine($"{name} {fatherName}");
        Console.ReadKey();
    }
}