using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePolindrome
{
    class Program
    {
        static void Main(string[] args) 
        {
            string s = string.Empty; //Represents the empty string. This field is read-only.
            Console.WriteLine("Enter");
            s = Console.ReadLine(); 
            //fill string 
            char[] temp = s.ToCharArray();//to array
            Array.Reverse(temp); //reverses
            string b = new string(temp); //assigning
            // convert it into array and reverse

            if (s.Equals(b))//compares it reverse version with original
            {
                Console.WriteLine("POLINDROME");
            }
            else
            {
                Console.WriteLine("NOT POLINDROME");
            }
            Console.ReadKey(); 
        }
    }
}
 