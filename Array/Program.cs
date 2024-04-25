using System;
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] names = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter name {i + 1}:");
                names[i] = Console.ReadLine();
            }
            foreach (string i in names)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Enter the target name:");
            string target = Console.ReadLine();
            int f = 0;
            for (int i = 0; i < 5; i++)
            {
                if (names[i] == target)
                {
                    Console.WriteLine($"The name is present in array at index {i}");
                    f = 1;
                    break;
                }
            }
            if (f == 0)
            {
                Console.WriteLine("The name is not present in array");
            }
            f = 0;
            foreach (string i in names)
            {
                if (i == target)
                {
                    Console.WriteLine("The name is present in array");
                    f = 1;
                    break;
                }
            }
            if (f == 0)
            {
                Console.WriteLine("The name is not present in array");
            }

            string a = "";
            a.Split(" ");

            Console.ReadKey();
        }
    }
}
