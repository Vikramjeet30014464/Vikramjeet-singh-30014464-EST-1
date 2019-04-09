/*Name : Vikramjeet Singh
 *student id = 30014464*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUS_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("......heyyyy.....");
            Console.ReadLine();

            Console.WriteLine("Question no 3");

            Console.WriteLine("Plase enter the price of five items");

            float total = 0;
            for (int i = 1; i <=5; i++)

                Console.WriteLine($"Please enter the number{i}:");
            total = total + float.Parse(Console.ReadLine());

            Console.WriteLine($"The number of the total those items {total}");
            Console.WriteLine("Enter for quit");
            Console.ReadLine();




         
         
                
        
        }
    }
}
