using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace lab1_4.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = @"C:\Users\Adile_000\desktop\text1.txt";    //  path of creation firtst file
            string b = @"C:\Users\Adile_000\\desktop\text2.txt";    //     second file
            string abs = "Lab work 2 task 4 is Solved!";
            StreamWriter dd = new StreamWriter(a);
            dd.Write(abs);
            dd.Close();
            //streamwriter increments characters to a file  then closes it 
            File.Copy(a, b);//Copy abs characters to a new file
            File.Delete(a);   //  Then delete исходный файл 
        }
    }
}
