using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
        //input
        Console.Write("Enter your name:");
        String name = Console.ReadLine();
        Console.Write("Enter age:");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject1:");
        int mark1 = int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2:");
        int mark2 = int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject3:");
        int mark3 = int.Parse(Console.ReadLine());
        Console.Write("Enter Grade:");
        char grade = char.Parse(Console.ReadLine());
        Console.Write("Enter mobile number:");
        long phNumber = long.Parse(Console.ReadLine());
        Console.Write("Enter Mail id:");
        String email=Console.ReadLine();

        int total = mark1+mark2+mark3;
        float avg = total/3.0f;
        
        //output
        Console.WriteLine("\n\nTrainee Details Are:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Mobile {name}");
        Console.WriteLine($"Marks1: {mark1}");
        Console.WriteLine($"Marks2: {mark2}");
        Console.WriteLine($"Marks2: {mark3}");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Mail id: {email}");
  
        Console.ReadKey();
    }
}