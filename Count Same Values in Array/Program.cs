using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> dict = new Dictionary<double, int>();

            foreach (var currentNumber in numbers)
            {
                if (!dict.ContainsKey(currentNumber))
                {
                    dict.Add(currentNumber, 0);
                }
                dict[currentNumber] += 1;
            }
            foreach (var (key,value) in dict)
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
