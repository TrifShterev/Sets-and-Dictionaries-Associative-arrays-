using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsDictionary = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var input = Console.ReadLine().Split();
                var student = input[0];
                var grade =decimal.Parse(input[1]);

                if (!studentsDictionary.ContainsKey(student))
                {
                    studentsDictionary.Add(student, new List<decimal>());
                }
                studentsDictionary[student].Add(grade);

            }
            foreach (var (student,grades) in studentsDictionary)
            {
              Console.WriteLine($"{student} ->{string.Join(" ",grades)}(avg: {grades.Average()}) ");
            }
        }
    }
}
