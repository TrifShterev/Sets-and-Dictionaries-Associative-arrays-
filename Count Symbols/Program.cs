using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> symbolsDict = new SortedDictionary<char, int>();
            string input = Console.ReadLine();

            foreach (char symbol in input)
            {
                if (!symbolsDict.ContainsKey(symbol))
                {
                    symbolsDict.Add(symbol, 0);
                }
                symbolsDict[symbol]++;
            }
            foreach (var item in symbolsDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}
