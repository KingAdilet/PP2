using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            //create an array and simultaneously convert it to binary
            string[] arr = Console.ReadLine().Split();
            //            fill array avoiding " "-gaps 
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(arr[i]);
            }
            //fill array  every ячейка one by one and converting it
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " " + a[i] + " ");
            }
            //Output in console

            Console.ReadKey();//close console window with pushing any button
        }
    }
}
