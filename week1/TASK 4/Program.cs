using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hello
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            //input the number for array
            int n = int.Parse(s);
            //for number give equivalent bit-number
            for (int i = 0; i < n; i++)//declaring cycle for array
            {
                for (int j = 0; j < i + 1; j++)//add second dimension to array 
                {
                    Console.Write("[*}");//filling 
                }
                Console.WriteLine();//output 
            }
            //typical code for creating and filling array with [*]

            Console.ReadKey();//to make console be closed after pushing any button

        }
    }
}
