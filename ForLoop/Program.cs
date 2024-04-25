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
        int sum=0;
        for(int i=num1;i<=num2;i++)
        {
            sum+=i*i;
        }
        Console.WriteLine($"Sum of the Square's between {num1} and {num2} : {sum}");
        Console.ReadKey();
    }
}
