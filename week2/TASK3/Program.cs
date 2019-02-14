using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2_3.cs
{
    class Program
    {
        static string Space(int a)//this function is required to have space in openning files
        {
            string s = "      ";
            string q = "";
            for (int i = 0; i < a; i++)
            {
                q += s;
            }
            return q;
        }
        static void qweqwe(DirectoryInfo dir, int a)//recursive function for openning folder and files, in tree scheme
        {  
            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] dires = dir.GetDirectories();
            foreach (FileInfo file in files)//show names of files with defined distance 
            {

                Console.Write(Space(a));
                Console.WriteLine(file.Name);
            }
            foreach (DirectoryInfo dire in dires)//for folders 
            {
                Console.Write(Space(a));//calls space function
                Console.WriteLine(dire.Name);
                qweqwe(dire, a + 1);
            }
        }
        static void Main(string[] args)//main fucntion gives path to folder to open and links functions to open them in right way with space distance
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Adile_000\source\repos\labworkd");
            qweqwe(dir, 0);
            Console.ReadKey();
        }
    }
}

