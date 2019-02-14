using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2.cs
{
    class Program
    {
        public static bool F1(int a)
        {
            if (a <= 1) return false;

            for (int i = 2; i < a; i++)
                if (a % i == 0) return true;            
            else return false;
        }
    
    
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] a = Console.ReadLine().Split();
            for (int i = 0; i <n; i++)
            {
                a[i] = int.Parse(a[i]);
            }
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                if (F1(a[i]) == true) sum++ ;
            }
            Console.WriteLine(sum);
            for (int i = 0; i < n; i++)
            {
                if (F1(a[i]) == true) 
                Console.WriteLine(a[i]+" ");
            }

        }
    }
}

