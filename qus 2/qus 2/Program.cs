/* Name = Vikramjeet Singh
 * Student id = 30014464*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------Can you solve the following algebraic expression:-----------------");
            Console.WriteLine("------------------2(x - 3) + x + 12 ----------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");

            /*2(x - 3 + x = 12
             * 2x -6 + x = 12
             * 3x - 6 = 12
             * 3x = 12 + 6
             * 3x = 18
             * x = 6*/
            Console.WriteLine("Enter your guess at the value of x: ");
            int guess = int.Parse(Console.ReadLine());


            Console.WriteLine("Sorry that guess is incorrect");
            Console.ReadLine();

              
        }
    }
}
