using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2
{
    class Student // создание класса
    {
        public string name; // public доступен из любого места программы
        public string id;
        public int yearofstudy = 1;
        public Student(string n, string i)// создание метода, метод - это именованный блок кода, который выполняет некоторые действия
        {
            name = n;//assign variables to name
            id = i;//assign variables to id
        }
        public void first()
        {
            Console.WriteLine(name + " " + id + " ");//function to show the name and id 
        }
        public void second()//incrementation function where we add +1 to original year of study
        {
            Console.WriteLine(yearofstudy + " before");
            yearofstudy++;
            Console.WriteLine(yearofstudy + " after increment"); 
        }
    }
    class Program
    {
        static void Main(string[] args)//Main is written to deal with several functions where linked in it
        {
            Student s = new Student("Adilet", "18BD120125");// using method student(constructor)
            s.first();//then we use first function to declare name and id
            s.second();//then we increment year of study
            Console.ReadKey();
        }
        
    }
}