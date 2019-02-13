using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_1.cs
{
    class Program
    {
        public static bool func(int x)
        {
            if (x <= 1) return false;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }//this boolean fucntion is essential to check whether number in array is prime or not
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
            }//fill array
            List<int> v = new List<int>();// we create empty container, to send there primes
            for (int i = 0; i < a.Length; i++)
            {
                if (func(a[i]) == true)
                    v.Add(a[i]);//if number is prime then we add that number to container"LIST" V;
            } //cycle to check prime number through function
            Console.WriteLine(v.ToArray().Length); //number of primes
            for (int i = 0; i < v.ToArray().Length; i++) 
            {
                Console.Write(v[i] + " ");
            }//cycle for output all primes from given array
            Console.ReadLine();

        }
    }
}
