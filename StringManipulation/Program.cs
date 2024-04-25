using System;
namespace StringManipulation;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Main String:");
        string Main = Console.ReadLine();
        Console.Write("String to be searched:");
        string sub = Console.ReadLine();

        int c=0;
        String res = Main.Replace(sub,"*");
        foreach(char i in res){
            if(i=='*'){
                c+=1;
            }
        }
        Console.WriteLine(c);
        Console.ReadKey();
    }
}
