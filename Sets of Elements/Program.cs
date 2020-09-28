using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstSetCount = sets[0];
            var secondSetCount = sets[1];

            HashSet<int> setOne = new HashSet<int>();
            HashSet<int> setSecond = new HashSet<int>();
            for (int i = 0; i < firstSetCount; i++)
            {
                int num = int.Parse(Console.ReadLine());
                setOne.Add(num);
            }
            for (int i = 0; i < secondSetCount; i++)
            {
                int num = int.Parse(Console.ReadLine());
                setSecond.Add(num);
            }
            setOne.IntersectWith(setSecond);
            
            Console.WriteLine(string.Join(" ",setOne));

            
        }
    }
}
