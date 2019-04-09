using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            
         
            //QUESTION 1 - LIAM SULLIVAN 30022060
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine(">>>This Prog will calculate base^exponent<<<");
          
            Console.WriteLine("Please enter the base number");
            double num1 = double.Parse(Console.ReadLine()); // The base number
            Console.WriteLine("Now enter the exponent number");
            int exp = int.Parse(Console.ReadLine()); // The exponent
            double fact = num1;

            while (num1 <= exp)
            {
                fact *= num1;
                num1++;
            }
            Console.WriteLine($"The Equation is {num1}^{exp} = {fact} ");
            Console.ReadLine(); // The equation
            
        }
    }
}
