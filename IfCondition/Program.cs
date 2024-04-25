using System; 
namespace HelloWorld 
{
    class Program
    {
        public static void Main(string[] args)
        {
	        Console.Write("Enter your mark : ");
            int mark=Convert.ToInt32(Console.ReadLine());

            if(mark>-1 && mark<101){
                if(mark>80)
                {
                    Console.WriteLine("Grade A");
                }
                else if(mark>60 && mark<81)
                {
                    Console.WriteLine("Grade B");
                }
                else if(mark>35 && mark<61)
                {
                    Console.WriteLine("Grade C");
                }
                else{
                    Console.WriteLine("Grade D");
                }
            }
            else{
	            Console.WriteLine("Invalid Input");    
            }
            
            Console.ReadKey();
	    }
    }
}
