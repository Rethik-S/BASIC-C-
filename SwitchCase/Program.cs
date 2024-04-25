using System; 
namespace HelloWorld; 
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number 1:");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter number 2:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("operations: \n1. +\n2. -\n3. *\n4./\n5.%");
        Console.Write("Enter an operation:");
        char option = char.Parse(Console.ReadLine());
        switch(option){
            case '+':
            {
                Console.WriteLine(num1+num2);
                break;
            }
            case '-':
            {
                Console.WriteLine(num1-num2);
                break;
            }
            case '*':
            {
                Console.WriteLine(num1*num2);
                break;
            }
            case '/':
            {
                Console.WriteLine(num1/num2);
                break;
            }
            case '%':
            {
                Console.WriteLine(num1%num2);
                break;
            }
            default:
            {
                Console.WriteLine("Operation is Invaild");
                break;
            }
        }
        Console.ReadKey();
    }
}
