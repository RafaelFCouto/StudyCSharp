using CourseRemote.Entities;
using System;
using System.Globalization;


namespace CourseRemote
{
    class Program
    {
        static void Main(string[] args)
        {

           HashSet<Student> students= new HashSet<Student>();


            Console.Write("How many students for course A? ");
            int qtdStudent = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdStudent; i++)
            {
                int number = int.Parse(Console.ReadLine());

                students.Add(new Student(number));

            }

            Console.Write("How many students for course B? ");
            qtdStudent = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdStudent; i++)
            {
                int number = int.Parse(Console.ReadLine());

                students.Add(new Student(number));

            }

            Console.Write("How many students for course C? ");
            qtdStudent = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdStudent; i++)
            {
                int number = int.Parse(Console.ReadLine());

                students.Add(new Student(number));

            }

            Console.WriteLine("Total students: " + students.Count);








        }
    }
}