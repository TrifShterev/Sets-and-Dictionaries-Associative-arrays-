using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(currentNum))
                {
                    numbers.Add(currentNum, 0);
                }
                numbers[currentNum]++;
            }
            var num = numbers.Where(x => x.Value % 2 == 0).FirstOrDefault().Key;
            Console.WriteLine(num);
            //foreach (var num in numbers)
            //{
            //    if (num.Value%2==0)
            //    {
            //        Console.WriteLine(num.Key);
            //        break;
            //    }
            //}
        }
    }
}
