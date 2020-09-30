using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            SortedSet<string> periodicTable = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
               var elements = Console.ReadLine().Split();
                foreach (var element in elements)
                {
                    periodicTable.Add(element);
                }

            }
            
            Console.WriteLine(string.Join(' ',periodicTable));
        }
    }
}
