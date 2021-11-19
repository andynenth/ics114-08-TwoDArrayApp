using System;

namespace TwoDArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDArray = new int[100,2];
            
            for (int i = 0; i < twoDArray.GetLongLength(0); i++)
            {
                    Random r = new Random();
                    twoDArray[i, 0] = r.Next(1, 101);
                    twoDArray[i, 1] = (int)Math.Pow(twoDArray[i, 0], 2);
            }
            
            Console.WriteLine("Random Values Squares\n");
            Console.WriteLine("{0,6} {1,13}" , "Random", "Number");
            Console.WriteLine("{0,6} {1,13}", "Number", "Squared");
            Console.WriteLine("----------------------");
            for (int i = 0; i < twoDArray.GetLongLength(0); i++)
            {
                Console.WriteLine("{0,5} {1,14}", twoDArray[i, 0], twoDArray[i, 1]);
            }
        }
    }
}
