using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for loop
            Console.WriteLine("How many times do yo want to say Hi?");
            int Counter = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Counter; i++)
                Console.WriteLine("Hello");

            //while loop
            int j = 0;
            while( j < 10)
            {
                j++;
                Console.WriteLine(j);
            }

            //do while loop
            do
            {
                Console.WriteLine(j);
                j++; 

            } while ( j<20);
            Console.ReadLine();
        }
    }
}
