using System;
using System.Collections.Generic;


namespace PlataformaDeCursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();



            Console.Write("How many students for course A? ");
            int numA = int.Parse(Console.ReadLine());
            for (int i = 0; i < numA; i++)
            {
                int students = int.Parse(Console.ReadLine());
                courseA.Add(students);
            }
            Console.Write("How many students for course B? ");
            int numB = int.Parse(Console.ReadLine());
            for (int i = 0; i < numB; i++)
            {
                int students = int.Parse(Console.ReadLine());
                courseB.Add(students);
            }
            Console.Write("How many students for course C? ");
            int numC = int.Parse(Console.ReadLine());
            for (int i = 0; i < numC; i++)
            {
                int students = int.Parse(Console.ReadLine());
                courseC.Add(students);
            }
            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.Write("Total students: " + all.Count);
        }
    }
}