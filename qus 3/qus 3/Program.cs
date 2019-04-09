/*Name = Vikramjeet Singh
 * Student id = 30014464*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qus_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("---------This program can give the result of base^exponent------");
            Console.WriteLine("----------------------------------------------------------------");


            Console.WriteLine("Please calculate the value of the base: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the value of the exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            Console.WriteLine($"exponent is {num1}^{exponent} = {exponent}");

            Console.WriteLine("Please enter for quit");
            Console.ReadLine();




        }
    }
}
