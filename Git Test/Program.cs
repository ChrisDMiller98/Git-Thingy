using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number A: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number B: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("I am thinking of a number between ");
            Console.Write(Num1);
            Console.Write(" and ");
            Console.WriteLine(Num2);
            Random random = new Random();
            int NumToGuess = random.Next(Num1, Num2);
            int UserGuess = 0;
            while (UserGuess != NumToGuess)
            {
                Console.Write("Enter Guess Here: ");
                UserGuess = Convert.ToInt32(Console.ReadLine());

                if (UserGuess < NumToGuess)
                {
                    Console.WriteLine("Too Low");

                }
                else if (UserGuess > NumToGuess)
                {
                    Console.WriteLine("Too High");
                }
                else
                {
                    Console.WriteLine("You Have Guessed Correctly!");
                }
            }
            Console.ReadKey();
        }
    }
}
