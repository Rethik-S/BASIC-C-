using System;
namespace DoWhileLoop; 
class Program
{
    public static void Main(string[] args)
    {
        int number;
        bool choice = true;
        do{
            Console.Write("Enter a number :");
            number=int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            
            while(choice){
                Console.WriteLine("you want to repeat the process ? - Yes/No");
                String option = Console.ReadLine();
                if(option=="Yes"){
                    choice=true;
                    break;
                }
                else if(option=="No"){
                    choice=false;
                    break;
                }
                else{
                     Console.WriteLine("Invalid input! choose Yes or No");
                }
            }
        }while(choice);
        
    }
}
