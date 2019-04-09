using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION 2 - LIAM SULLIVAN 30022060

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(">>>This prog will will ask for 5 prices and add the sums up<<<");

            float total = 0; //The base total           
            for (decimal num1 = 1; num1 <= 5; num1++) //Loop used to repeat 5 five times
            {
                Console.Write($"Please enter a price for item {num1}: "); //Ask for numbers 5 times
                
                total = total + float.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nThe Total of all items is ${total}"); //Total amount
            Console.ReadLine();

        

        }
    }
}
