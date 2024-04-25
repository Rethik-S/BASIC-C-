using System;
using System.Net.NetworkInformation;
namespace Method;
class Program
{
    public static void Main(string[] args)
    {
        string choice = "Yes";
        do
        {
            Console.Write("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter from these options: ");
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine(Addition(num1, num2));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(Subtract(num1, num2));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(Multiply(num1, num2));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(Division(num1, num2));
                        break;
                    }
            }
            do
            {
                Console.Write("Do you want to continue { Yes/No }:");
                string cont = Console.ReadLine();
                if ( cont == "Yes")
                {
                    break;                    
                }
                else if (cont=="No")
                {
                    choice="No";
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input provide Yes/No");
                }
            } while (true);
        } while (choice == "Yes");
    }
    static int Addition(int a, int b)
    {
        return a + b;
    }
    static int Subtract(int a, int b)
    {
        return a - b;
    }
    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static float Division(float a, float b)
    {
        return a / b;
    }
}




