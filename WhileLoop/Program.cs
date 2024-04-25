using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
namespace WhileLoop; 
class Program
{
    public static void Main(string[] args)
    {
        //Exercise 1
        int i=0;
        while(i<26){
            Console.WriteLine(i);
            i++;
        }

        //Exercise 2
        
        int number;
        while(true)
        {
            Console.Write("Enter a number:");
            if(int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine(number);
                break;
            }
            Console.WriteLine("Invalid input format. Please enter the input in number format");
        }
        
        Console.ReadKey();
    }
}
