using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2.cs
{
    class Program
    {
        public static bool func(int x)
        {
            if (x <= 1) return false;//already not prime
            for(int i=2; i<x; i++)
            {
                if (x % i == 0) return false;//number is prime only if it is divisible by itselgf
            }
            return true;
        }//this boolean fucntion is essential to check whether number in array is prime or not
        static void Main(string[] args)
        {
            string s = System.IO.File.ReadAllText(@"C:\Users\Adile_000\Desktop\input.txt");
            //reads txt file with array init, assign path to get exact file, and assign them a string
            int[] a = new int[s.Length]; //create array with length of numbers in input file
            a = s.Split().Select(int.Parse).ToArray(); //fill that array with numbers from string;
            List<int> v = new List<int>();// we create empty container, to send there primes
            for(int i=0; i<a.Length; i++)
            {
                if (func(a[i]) == true)
                    v.Add(a[i]);//if number is prime then we add that number to container"LIST" V;
            } //cycle to check prime number through function
            string result = String.Join(" ", v.ToArray());
            System.IO.File.WriteAllText(@"C:\Users\Adile_000\Desktop\output.txt",result);
            //path to insert checked prime n

        }
    }
}
