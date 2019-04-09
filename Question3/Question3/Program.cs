using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t2(x - 3) + x = 12");
            Console.WriteLine(">>>Here is an algebraic expression. Can you solve it?<<<");
            Console.WriteLine("\nEnter your guess here on what x could be:");

            int guess = int.Parse(Console.ReadLine());
            if(guess == 6)
            {
                Console.WriteLine("You are correct");
              
            }
            else
                Console.WriteLine("Sorry. That was incorrect.");
            Console.ReadLine();
        

        }
    }
}
