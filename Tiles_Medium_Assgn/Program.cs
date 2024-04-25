using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int N =int.Parse(Console.ReadLine());
                double W =double.Parse(Console.ReadLine());
                double L =double.Parse(Console.ReadLine());
                int M =int.Parse(Console.ReadLine());
                int O =int.Parse(Console.ReadLine());
                int totalArea =N*N;
                int bench=M*O;
                int area = totalArea-bench;
                double tileArea = W*L;
                double tiles=area/tileArea;
                double time = tiles*0.2;
                Console.WriteLine($"Number of tiles needed {Math.Round(tiles,2)}");
                Console.WriteLine($"Total time for changing {Math.Round(time,1)}");
            }
        }
            